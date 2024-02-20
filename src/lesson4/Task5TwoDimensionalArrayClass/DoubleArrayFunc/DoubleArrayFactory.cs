namespace Task5TwoDimensionalArrayClass.DoubleArrayFunc;

public class DoubleArrayFactory
{
    private readonly Random _random = new Random();
    protected IFile File = new FileAdapter();

    public DoubleArray RandomCreate(int colCount, int rowCount)
    {
        var array = new int[colCount, rowCount];
        for (var i = 0; i < colCount; i++)
        {
            for (int j = 0; j < rowCount; j++)
            {
                array[i, j] = _random.Next(0, 1001);
            }
        }
        return new DoubleArray(array);
    }

    public DoubleArray CreateFromFile(string path)
    {
        if (!File.Exists(path)) throw new FileLoadException("Файл отсутствует");

        var values = readValuesFromFile(path);
        return new DoubleArray(values);
    }

    private int[,] readValuesFromFile(string path)
    {
        var lines = File.ReadAllLines(path);
        var arrSize = lines[0].Split(',');
        var linesCount = int.Parse(arrSize[0]);
        var countInLine = int.Parse(arrSize[1]);
        var results = new int[linesCount, countInLine];
        for (var i = 0; i < linesCount; i++)
        {
            var values = lines[i + 1].Split(',');
            for (var j = 0; j < countInLine; j++)
            {
                results[i, j] = int.Parse(values[j]);
            }
        }
        return results;
    }
}