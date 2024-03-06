namespace Task2StaticClass.StaticCounterFunc.Internal;

internal class ArraySaveFile : IArraySaveFile
{
    private ArraySaveFile()
    {

    }

    public static IArraySaveFile Create()
    {
        return new ArraySaveFile();
    }

    public void SaveArrayToFile(IEnumerable<int> numbers, string fileName)
    {
        using var writer = new StreamWriter(fileName);
        foreach (int item in numbers)
        {
            writer.WriteLine(item.ToString());
        }
    }
}