namespace Task4UserPasswordsTests.AccountsFunc;

public class AccountsManagerTests
{
    [Theory]
    [InlineData("root", true)]
    [InlineData("incorrect", false)]
    public void TestUsernameCheck(string username, bool expected)
    {
        var loginPasswords = new[] { ("root", "GeekBrains") };
        var manager = AccountsManager.Create(loginPasswords);

        var actual = manager.UsernameCheck(username);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData("root", "GeekBrains", true)]
    [InlineData("root", "incorrect", false)]
    public void TestCheck(string username, string password, bool expected)
    {
        var loginPasswords = new[] { ("root", "GeekBrains") };
        var manager = AccountsManager.Create(loginPasswords);

        var actual = manager.Check(username, password);

        actual.Should().Be(expected);
    }
}