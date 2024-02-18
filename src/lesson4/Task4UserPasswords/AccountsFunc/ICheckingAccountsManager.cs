namespace Task4UserPasswords.AccountsFunc;

public interface ICheckingAccountsManager
{
    bool UsernameCheck(string username);

    bool Check(string username, string password);
}