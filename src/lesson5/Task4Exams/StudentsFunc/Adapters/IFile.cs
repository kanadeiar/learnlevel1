namespace Task4Exams.StudentsFunc.Adapters;

public interface IFile
{
    void WriteAllLines(string path, string[] lines);
    bool Exists(string path);
    string[] ReadAllLines(string path);
}