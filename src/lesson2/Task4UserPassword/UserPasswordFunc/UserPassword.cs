namespace Task4UserPassword.UserPasswordFunc;

public class UserPassword : ICheckingUserPassword
{
    private const string USERNAME = "root";
    private const string PASSWORD = "GeekBrains";

    public UserPassword()
    {
        
    }

    public bool Check(string username, string password)
    {
        var result = username == USERNAME && password == PASSWORD;
        return result;
    }
}