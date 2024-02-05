namespace Task4UserPassword.UserPasswordFunc;

public interface ICheckingUserPassword
{
    bool Check(string username, string password);
}