namespace Task4UserPassword.CheckpointFunc;

public interface ICheckCheckpoint
{
    bool IsBlocked();
    bool CheckUserPassword(string username, string password);
}