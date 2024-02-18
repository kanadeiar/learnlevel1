namespace Task4UserPasswords.AccountsFunc;

internal struct Account
{
    private string _login;
    private string _password;

    public Account(string login, string password)
    {
        _login = login;
        _password = password;
    }

    public bool CheckLogin(string login)
    {
        return _login == login;
    }

    public bool CheckLoginPassword(string login, string password)
    {
        return _login == login && _password == password;
    }
}