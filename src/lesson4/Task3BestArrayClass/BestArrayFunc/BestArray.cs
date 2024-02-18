namespace Task3BestArrayClass.BestArrayFunc;

public class BestArray
{
    private int[] _array;

    internal BestArray(int[] numbers)
    {
        _array = numbers;
    }

    public static BestArrayFactory Factory = new ();

    public int Max => _array.Max();
    
    public int Sum => _array.Sum();

    public BestArray Inverse
    {
        get
        {
            var result = new int[_array.Length];
            for (var i = 0; i < _array.Length; i++)
            {
                result[i] = - _array[i];
            }
            return new BestArray(result);
        }
    }

    public BestArray Multiply(int value)
    {
        var result = new int[_array.Length];
        for (var i = 0; i < _array.Length; i++)
        {
            result[i] = _array[i] * value;
        }
        return new BestArray(result);
    }

    public object MaxCount
    {
        get
        {
            var max = Max;
            return _array.Count(item => item == max);
        }
    }

    public int this[int i]
    {
        get => _array[i];
        set => _array[i] = value;
    }

    public int Length => _array.Length;

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var each in _array)
        {
            sb.Append($"{each,4} ");
        }
        return sb.ToString();
    }
}