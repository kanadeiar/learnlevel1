using Task3BestArrayClass.BestArrayFunc.Adapters;

namespace Task3BestArrayClass.BestArrayFunc;

public class BestArrayFactory()
{
    private readonly Random _random = new Random();

    protected IFile File = new FileAdapter();

    public ICommonBestArray RandomCreate(int size)
    {
        var array = new int[size];
        for (var i = 0; i < size; i++)
        {
            array[i] = _random.Next(1, 101);
        }
        return new BestArray(array);
    }

    public ICommonBestArray CreateFromFile(string fileName)
    {
        if (!File.Exists(fileName)) throw new FileLoadException("Файл отсутствует");

        var array = readArrayFromFile(fileName);
        return new BestArray(array);
    }

    private int[] readArrayFromFile(string fileName)
    {
        string[] strings = File.ReadAllLines(fileName);
        var array = new int[strings.Length];
        for (var i = 0; i < strings.Length; i++)
        {
            array[i] = int.Parse(strings[i]);
        }

        return array;
    }

    public ICommonBestArray Create(int start, int step, int size)
    {
        var array = new int[size];
        for (var i = 0; i < size; i++)
        {
            array[i] = start + i * step;
        }
        return new BestArray(array);
    }
}