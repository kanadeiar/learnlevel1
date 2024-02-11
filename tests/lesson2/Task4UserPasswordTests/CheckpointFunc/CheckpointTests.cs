namespace Task4UserPasswordTests.CheckpointFunc;

public class CheckpointTests
{
    [Theory, MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword(Mock<ICheckingUserPassword> mock)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(new Task4UserPassword.CheckpointFunc.UserPasswordFuncAdapter(mock.Object));

        var actual = checkpoint.CheckUserPassword("root", "GeekBrains");

        actual.Should().BeTrue();
        mock.Verify(x => x.Check("root", "GeekBrains"), Times.Once);
    }

    [Theory, MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword_WhenIncorrect(Mock<ICheckingUserPassword> mock)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(new Task4UserPassword.CheckpointFunc.UserPasswordFuncAdapter(mock.Object));

        var actual = checkpoint.CheckUserPassword("incorrect", "incorrect");

        checkpoint.IsBlocked().Should().BeFalse();
        actual.Should().BeFalse();
        mock.Verify(x => x.Check("incorrect", "incorrect"), Times.Once);
    }

    [Theory, MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword_WhenIncorrect3Times_ThenBlocked(Mock<ICheckingUserPassword> mock)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(new Task4UserPassword.CheckpointFunc.UserPasswordFuncAdapter(mock.Object));

        var actual = false;
        for (var i = 0; i < 3; i++)
        {
            actual = checkpoint.CheckUserPassword("incorrect", "incorrect");
        }

        checkpoint.IsBlocked().Should().BeTrue();
        actual.Should().BeFalse();
        mock.Verify(x => x.Check("incorrect", "incorrect"), Times.Exactly(3));
    }

    [Theory, MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword_WhenBlocked_ThenIncorrect(Mock<ICheckingUserPassword> mock)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(new Task4UserPassword.CheckpointFunc.UserPasswordFuncAdapter(mock.Object));

        bool actual;
        for (var i = 0; i < 3; i++)
        {
            checkpoint.CheckUserPassword("incorrect", "incorrect");
        }
        actual = checkpoint.CheckUserPassword("root", "GeekBrains");

        actual.Should().BeFalse();
        mock.Verify(x => x.Check(It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(3));
    }

    public static IEnumerable<object[]> UserPasswordSource()
    {
        var fixture = new Fixture();
        fixture.Freeze<Mock<ICheckingUserPassword>>()
            .Setup(x => x.Check("root", "GeekBrains"))
            .Returns(true);
        var mock = fixture.Create<Mock<ICheckingUserPassword>>();
        
        yield return new object[] { mock };
    }
}