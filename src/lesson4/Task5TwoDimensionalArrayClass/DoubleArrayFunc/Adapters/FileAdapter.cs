namespace Task5TwoDimensionalArrayClass.DoubleArrayFunc.Adapters;

public class FileAdapter : IFile
{
    public bool Exists(string path)
    {
        return File.Exists(path);
    }

    public string[] ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }

    public void WriteAllLines(string path, string[] lines)
    {
        File.WriteAllLines(path, lines);
    }
}