namespace Task4UserPasswords.CheckpointFunc;

public interface ICheckCheckpoint
{
    bool IsBlocked();
    bool CheckUserPassword(string username, string password);
}