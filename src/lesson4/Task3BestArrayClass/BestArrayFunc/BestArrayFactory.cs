namespace Task3BestArrayClass.BestArrayFunc;

public class BestArrayFactory()
{
    private readonly Random _random = new Random();

    public BestArray Create(int size)
    {
        var array = new int[size];
        for (var i = 0; i < size; i++)
        {
            array[i] = _random.Next(1, 101);
        }
        return new BestArray(array);
    }

    public BestArray Create(string fileName, IFile? adapter = null)
    {
        var file = adapter ?? new FileAdapter();
        var isFileExists = file.Exists(fileName);
        if (isFileExists)
        {
            var array = readArrayFromFile(fileName, file);
            return new BestArray(array);
        }
        throw new FileLoadException("Файл отсутствует");
    }

    private static int[] readArrayFromFile(string fileName, IFile file)
    {
        string[] strings = file.ReadAllLines(fileName);
        var array = new int[strings.Length];
        for (var i = 0; i < strings.Length; i++)
        {
            array[i] = int.Parse(strings[i]);
        }

        return array;
    }

    public BestArray Create(int start, int step, int size)
    {
        var array = new int[size];
        for (var i = 0; i < size; i++)
        {
            array[i] = start + i * step;
        }
        return new BestArray(array);
    }
}