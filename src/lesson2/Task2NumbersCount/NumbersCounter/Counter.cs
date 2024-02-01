namespace Task2NumbersCount.NumbersCounter;

public class Counter : ICommonCounter
{
    private int _number;

    public int Number => _number;

    public Counter(int number)
    {
        _number = number;
    }
    public static ICommonCounter Create(int number)
    {
        return new Counter(number);
    }

    public int GetCount()
    {
        return countWithDivision(_number);
    }

    private static int countWithDivision(int number)
    {
        int count = default;
        while (number > 0)
        {
            count++;
            number = number / 10;
        }
        return count;
    }
}