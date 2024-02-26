namespace Task4Exams.StudentsFunc.Adapters;

public class FileAdapter : IFile
{
    public void WriteAllLines(string path, string[] lines)
    {
        File.WriteAllLines(path, lines);
    }

    public bool Exists(string path)
    {
        return File.Exists(path);
    }

    public string[] ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }
}