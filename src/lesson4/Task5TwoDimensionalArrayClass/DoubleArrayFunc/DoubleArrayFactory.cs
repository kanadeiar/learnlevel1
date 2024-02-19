namespace Task5TwoDimensionalArrayClass.DoubleArrayFunc;

public class DoubleArrayFactory
{
    private readonly Random _random = new Random();

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
}