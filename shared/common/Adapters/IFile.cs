namespace Kanadeiar.Common.Adapters;

public interface IFile
{
    bool Exists(string fileName);
    string[] ReadAllLines(string fileName);
}