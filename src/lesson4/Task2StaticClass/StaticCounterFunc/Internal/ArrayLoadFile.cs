namespace Task2StaticClass.StaticCounterFunc.Internal;

internal class ArrayLoadFile : IArrayLoadFile
{
    private ArrayLoadFile()
    {
        
    }

    public static IArrayLoadFile Create()
    {
        return new ArrayLoadFile();
    }

    public IEnumerable<int> LoadArrayFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            throw new FileNotFoundException($"Файл не существует: {fileName}");
        }

        using var reader = new StreamReader(fileName);
        List<int> results = new List<int>();
        while (reader.EndOfStream == false)
        {
            results.Add(int.Parse(reader.ReadLine()!));
        }
        return results;
    }
}