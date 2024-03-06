namespace Task2StaticClass.StaticCounterFunc.Internal;

public interface IArraySaveFile
{
    void SaveArrayToFile(IEnumerable<int> numbers, string fileName);
}