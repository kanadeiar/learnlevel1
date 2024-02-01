namespace Task2NumbersCount.NumbersCounter;

public class Counter : IDataCounter
{
    private int _number;

    public int Number => _number;

    public Counter(int number)
    {
        _number = number;
    }
    public static IDataCounter Create(int number)
    {
        return new Counter(number);
    }
}