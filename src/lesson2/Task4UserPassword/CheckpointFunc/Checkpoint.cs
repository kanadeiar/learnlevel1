namespace Task4UserPassword.CheckpointFunc;

public class Checkpoint : ICheckCheckpoint
{
    private UserPasswordFuncAdapter _checkingUserPasswordFunc;
    private int _count;

    private Checkpoint(UserPasswordFuncAdapter checkingUserPasswordFunc)
    {
        _checkingUserPasswordFunc = checkingUserPasswordFunc;
    }

    public static Checkpoint Create(UserPasswordFuncAdapter checkingUserPasswordFunc)
    {
        return new Checkpoint(checkingUserPasswordFunc);
    }

    public bool IsBlocked() => _count >= 3;

    public bool CheckUserPassword(string username, string password)
    {
        if (IsBlocked()) return false;

        if (_checkingUserPasswordFunc.Check(username, password))
        {
            return true;
        }
        _count++;
        return false;
    }
}