using System.Text;

namespace Task5TwoDimensionalArrayClass.DoubleArrayFunc;

public class DoubleArray
{
    private int[,] _array;
    protected IFile File = new FileAdapter();

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
        for (var i = 0; i < RowCount; i++)
        {
            for (var j = 0; j < ColCount; j++)
            {
                if (_array[i, j] == value)
                {
                    return (i, j);
                }
            }
        }
        return (-1, -1);
    }

    public void SaveToFile(string path)
    {
        var lines = new List<string> { $"{RowCount},{ColCount}" };
        for (var i = 0; i < RowCount; i++)
        {
            var numbers = new int[ColCount];
            for (var j = 0; j < ColCount; j++)
            {
                numbers[j] = _array[i, j];
            }
            lines.Add(string.Join(',', numbers));
        }
        File.WriteAllLines(path, lines.ToArray());
    }

    public int this[int i, int j]
    {
        get => _array[i, j];
        set => _array[i, j] = value;
    }

    public int Length => _array.Length;

    public int ColCount => _array.GetLength(1);

    public int RowCount => _array.GetLength(0);
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < RowCount; i++)
        {
            for (int j = 0; j < ColCount; j++)
            {
                sb.Append(_array[i, j] + " ");
            }
            sb.Append("\n");
        }
        return sb.ToString();
    }
}