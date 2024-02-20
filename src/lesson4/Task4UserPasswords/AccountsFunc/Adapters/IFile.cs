namespace Task4UserPasswords.AccountsFunc.Adapters;

public interface IFile
{
    bool Exists(string fileName);
    string[] ReadAllLines(string fileName);
}