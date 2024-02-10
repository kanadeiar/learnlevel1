namespace Task4UserPassword.CheckpointFunc;

public class Checkpoint : ICheckCheckpoint
{
    private ICheckingUserPassword _checkingUserPassword;
    private int _count;

    private Checkpoint(ICheckingUserPassword checkingUserPassword)
    {
        _checkingUserPassword = checkingUserPassword;
    }

    public static Checkpoint Create(ICheckingUserPassword checkingUserPassword)
    {
        return new Checkpoint(checkingUserPassword);
    }

    public bool IsBlocked() => _count >= 3;

    public bool CheckUserPassword(string username, string password)
    {
        if (IsBlocked()) return false;

        if (_checkingUserPassword.Check(username, password))
        {
            return true;
        }
        _count++;
        return false;
    }
}