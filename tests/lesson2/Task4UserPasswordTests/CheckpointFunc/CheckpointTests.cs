namespace Task4UserPasswordTests.CheckpointFunc;

public class CheckpointTests
{
    public static IEnumerable<object[]> UserPasswordSource()
    {
        var checkMock = new Mock<ICheckingUserPassword>();
        checkMock
            .Setup(x => x.Check("incorrect", "incorrect"))
            .Returns(false);
        checkMock
            .Setup(x => x.Check("root", "GeekBrains"))
            .Returns(true);
        
        yield return new object[] { checkMock.Object };
    }

    [Theory]
    [MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword(ICheckingUserPassword userPassword)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(userPassword);

        var actual = checkpoint.CheckUserPassword("root", "GeekBrains");

        Assert.True(actual);
    }

    [Theory]
    [MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword_WhenIncorrect(ICheckingUserPassword userPassword)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(userPassword);

        var actual = checkpoint.CheckUserPassword("incorrect", "incorrect");

        Assert.False(checkpoint.IsBlocked());
        Assert.False(actual);
    }

    [Theory]
    [MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword_WhenIncorrect3Times_ThenBlocked(ICheckingUserPassword userPassword)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(userPassword);

        var actual = false;
        for (var i = 0; i < 3; i++)
        {
            actual = checkpoint.CheckUserPassword("incorrect", "incorrect");
        }

        Assert.True(checkpoint.IsBlocked());
        Assert.False(actual);
    }

    [Theory]
    [MemberData(nameof(UserPasswordSource))]
    public void TestCheckUserPassword_WhenBlocked_ThenIncorrect(ICheckingUserPassword userPassword)
    {
        ICheckCheckpoint checkpoint = Checkpoint.Create(userPassword);

        bool actual;
        for (var i = 0; i < 3; i++)
        {
            checkpoint.CheckUserPassword("incorrect", "incorrect");
        }
        actual = checkpoint.CheckUserPassword("root", "GeekBrains");

        Assert.False(actual);
    }
}