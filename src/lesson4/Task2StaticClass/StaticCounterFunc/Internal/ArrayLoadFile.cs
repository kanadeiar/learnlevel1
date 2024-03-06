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
        var path = Path.Combine(Environment.CurrentDirectory, fileName);
        if (File.Exists(path) == false)
        {
            throw new FileNotFoundException($"Файл не существует: {path}");
        }

        using var reader = new StreamReader(path);
        List<int> results = new List<int>();
        while (reader.EndOfStream == false)
        {
            results.Add(int.Parse(reader.ReadLine()!));
        }
        return results;
    }
}