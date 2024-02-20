namespace Task3BestArrayClass.BestArrayFunc.Adapters;

public interface IFile
{
    bool Exists(string fileName);
    string[] ReadAllLines(string fileName);
}