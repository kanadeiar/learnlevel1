namespace Task4UserPasswordsTests.AccountsFunc.TestBase;

public class AccountsManagerFactoryFake : AccountsManagerFactory
{
    public AccountsManagerFactoryFake(IFile file)
    {
        File = file;
    }
}