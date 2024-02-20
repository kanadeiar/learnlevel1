using Task4UserPasswordsTests.AccountsFunc.TestBase;

namespace Task4UserPasswordsTests.AccountsFunc;

public class AccountsManagerTests
{
    [Theory]
    [InlineData("root", true)]
    [InlineData("incorrect", false)]
    public void TestUsernameCheck(string username, bool expected)
    {
        var loginPasswords = new[] { ("root", "GeekBrains") };
        ICheckingAccountsManager manager = AccountsManager.Factory.Create(loginPasswords);

        var actual = manager.UsernameCheck(username);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData("root", "GeekBrains", true)]
    [InlineData("root", "incorrect", false)]
    public void TestCheck(string username, string password, bool expected)
    {
        var loginPasswords = new[] { ("root", "GeekBrains") };
        ICheckingAccountsManager manager = AccountsManager.Factory.Create(loginPasswords);

        var actual = manager.Check(username, password);

        actual.Should().Be(expected);
    }

    [Theory, AutoMoqData]
    public void TestCreate_WhenFromFile([Frozen] Mock<IFile> mock)
    {
        var expected = new [] { "test,pass" };
        mock.Setup(x => x.Exists("test.txt")).Returns(true);
        mock.Setup(x => x.ReadAllLines("test.txt")).Returns(expected);
        var factory = new AccountsManagerFactoryFake(mock.Object);

        ICheckingAccountsManager manager = factory.CreateFromFile("test.txt");

        var actual = manager.Check("test", "pass");
        mock.Verify(x => x.Exists("test.txt"), Times.Once);
        actual.Should().BeTrue();
    }
}