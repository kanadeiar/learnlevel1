namespace Task2StaticClass.StaticCounterFunc.Internal;

public interface IArrayLoadFile
{
    IEnumerable<int> LoadArrayFromFile(string fileName);
}