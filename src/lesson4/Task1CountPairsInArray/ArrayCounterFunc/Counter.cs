namespace Task1CountPairsInArray.ArrayCounterFunc;

public class Counter
{
    public int Count(int[] numbers)
    {
        var count = 0;
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            if (isGoodPair(numbers[i], numbers[i + 1]))
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