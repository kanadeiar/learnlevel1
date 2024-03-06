namespace Task4UserPassword.CheckpointFunc;

public class UserPasswordFuncAdapter
{
    private readonly ICheckingUserPassword _password;
    
    public UserPasswordFuncAdapter(ICheckingUserPassword password)
    {
        _password = password;
    }

    public bool Check(string username, string password)
    {
        return _password.Check(username, password);
    }
}