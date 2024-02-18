namespace Task4UserPasswords.CheckpointFunc;

public class UserPasswordFuncAdapter
{
    private readonly ICheckingAccountsManager _password;
    
    public UserPasswordFuncAdapter(ICheckingAccountsManager password)
    {
        _password = password;
    }

    public bool Check(string username, string password)
    {
        return _password.Check(username, password);
    }
}