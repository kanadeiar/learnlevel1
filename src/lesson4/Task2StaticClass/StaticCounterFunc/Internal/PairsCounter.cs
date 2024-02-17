namespace Task2StaticClass.StaticCounterFunc.Internal;

internal class PairsCounter
{
    private int[] _values;

    public PairsCounter(IEnumerable<int> numbers)
    {
        _values = numbers.ToArray();
    }

    public int CountGoodPairs()
    {
        var count = 0;
        for (var i = 0; i < _values.Length - 1; i++)
        {
            if (isGoodPair(_values[i], _values[i + 1]))
            {
                count++;
            }
        }
        return count;
    }

    private static bool isGoodPair(int first, int second)
    {
        return first % 3 == 0 ^ second % 3 == 0;
    }
}