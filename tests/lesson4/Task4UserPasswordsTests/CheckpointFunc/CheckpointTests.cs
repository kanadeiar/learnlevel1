namespace Task4UserPasswordsTests.CheckpointFunc;

public class CheckpointTests
{
    [Theory, MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword(Mock<ICheckingAccountsManager> mock)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(new UserPasswordFuncAdapter(mock.Object));

        var actual = checkpoint.CheckUserPassword("root", "GeekBrains");

        actual.Should().BeTrue();
        mock.Verify(x => x.Check("root", "GeekBrains"), Times.Once);
    }

    [Theory, MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword_WhenIncorrect(Mock<ICheckingAccountsManager> mock)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(new UserPasswordFuncAdapter(mock.Object));

        var actual = checkpoint.CheckUserPassword("incorrect", "incorrect");

        checkpoint.IsBlocked().Should().BeFalse();
        actual.Should().BeFalse();
        mock.Verify(x => x.Check("incorrect", "incorrect"), Times.Once);
    }

    public static IEnumerable<object[]> UserPasswordSource()
    {
        var fixture = new Fixture();
        fixture.Freeze<Mock<ICheckingAccountsManager>>()
            .Setup(x => x.Check("root", "GeekBrains"))
            .Returns(true);
        var mock = fixture.Create<Mock<ICheckingAccountsManager>>();

        yield return new object[] { mock };
    }
}