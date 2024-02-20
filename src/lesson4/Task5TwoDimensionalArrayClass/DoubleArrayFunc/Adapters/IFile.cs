namespace Task5TwoDimensionalArrayClass.DoubleArrayFunc.Adapters;

public interface IFile
{
    bool Exists(string fileName);
    string[] ReadAllLines(string fileName);
    void WriteAllLines(string path, string[] lines);
}