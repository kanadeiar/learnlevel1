namespace Task3BestArrayClass.BestArrayFunc.Adapters;

public class FileAdapter : IFile
{
    public bool Exists(string fileName)
    {
        return File.Exists(fileName);
    }

    public string[] ReadAllLines(string fileName)
    {
        return File.ReadAllLines(fileName);
    }
}