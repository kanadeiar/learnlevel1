namespace Task3BestArrayClass.BestArrayFunc;

public class BestArrayFactory()
{
    private readonly Random _random = new Random();

    public ICommonBestArray RandomCreate(int size)
    {
        var array = new int[size];
        for (var i = 0; i < size; i++)
        {
            array[i] = _random.Next(1, 101);
        }
        return new CommonBestArray(array);
    }

    public ICommonBestArray CreateFromFile(string fileName, IFile? adapter = null)
    {
        var file = adapter ?? new FileAdapter();
        if (!file.Exists(fileName)) throw new FileLoadException("Файл отсутствует");

        var array = readArrayFromFile(fileName, file);
        return new CommonBestArray(array);
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

    public ICommonBestArray Create(int start, int step, int size)
    {
        var array = new int[size];
        for (var i = 0; i < size; i++)
        {
            array[i] = start + i * step;
        }
        return new CommonBestArray(array);
    }
}