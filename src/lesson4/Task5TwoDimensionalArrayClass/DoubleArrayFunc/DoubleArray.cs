namespace Task5TwoDimensionalArrayClass.DoubleArrayFunc;

public class DoubleArray
{
    private int[,] _array;

    public DoubleArray(int[,] numbers)
    {
        _array = numbers;
    }

    public static DoubleArrayFactory Factory = new();

    public int Sum()
    {
        return _array.Cast<int>().Sum();
    }

    public int GreaterSum(int number)
    {
        return _array.Cast<int>().Where(n => n > number).Sum();
    }

    public int Min => _array.Cast<int>().Min();

    public int Max => _array.Cast<int>().Max();

    public (int, int) GetIndexForValue(int value)
    {
        for (var i = 0; i < _array.GetLength(1); i++)
        {
            for (var j = 0; j < _array.GetLength(0); j++)
            {
                if (_array[j, i] == value)
                {
                    return (j, i);
                }
            }
        }
        return (-1, -1);
    }

    public int this[int i, int j]
    {
        get => _array[i, j];
        set => _array[i, j] = value;
    }

    public int Length => _array.Length;

    public int ColCount => _array.GetLength(0);

    public int RowCount => _array.GetLength(1);
}