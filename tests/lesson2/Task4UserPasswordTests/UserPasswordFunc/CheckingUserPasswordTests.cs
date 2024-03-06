namespace Task4UserPasswordTests.UserPasswordFunc;

public class CheckingUserPasswordTests
{
    [Fact]
    public void TestCheck()
    {
        ICheckingUserPassword userPassword = new UserPassword();

        var actual = userPassword.Check("root", "GeekBrains");

        actual.Should().BeTrue();
    }

    [Theory]
    [InlineData("root", "incorrect")]
    [InlineData("incorrect", "GeekBrains")]
    public void TestCheck_WhenIncorrect(string user, string password)
    {
        ICheckingUserPassword userPassword = new UserPassword();

        var actual = userPassword.Check(user, password);

        actual.Should().BeFalse();
    }
}