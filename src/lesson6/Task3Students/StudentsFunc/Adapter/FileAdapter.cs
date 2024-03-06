namespace Task3Students.StudentsFunc.Adapter;

public class FileAdapter : IFile
{
    public bool Exists(string path)
    {
        return File.Exists(path);
    }

    public void WriteAllLines(string path, string[] lines)
    {
        File.WriteAllLines(path, lines);
    }

    public string[] ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }
}