namespace Task3Students.StudentsFunc.Adapter;

public interface IFile
{
    bool Exists(string path);
    void WriteAllLines(string path, string[] lines);
    string[] ReadAllLines(string path);
}