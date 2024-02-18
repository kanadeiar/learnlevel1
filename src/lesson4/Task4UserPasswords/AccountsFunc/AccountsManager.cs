namespace Task4UserPasswords.AccountsFunc;

public class AccountsManager : ICheckingAccountsManager
{
    private Account[] _accounts;

    private AccountsManager(IEnumerable<(string, string)> accounts)
    {
        _accounts = accounts.Select(x => new Account(x.Item1, x.Item2)).ToArray();
    }

    public static ICheckingAccountsManager Create(IEnumerable<(string, string)> accounts)
    {
        return new AccountsManager(accounts);
    }

    //public static ICheckingAccountsManager Create(string fileName)
    //{

    //}

    public bool UsernameCheck(string username)
    {
        return _accounts.Any(account => account.CheckLogin(username));
    }

    public bool Check(string username, string password)
    {
        return _accounts.Any(account => account.CheckLoginPassword(username, password));
    }
}