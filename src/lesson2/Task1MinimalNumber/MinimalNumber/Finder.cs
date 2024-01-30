namespace Task1MinimalNumber.MinimalNumber;

public class Finder : ICommonFinder
{
    private readonly int[] _numbers;

    public IEnumerable<int> Numbers => _numbers;

    private Finder(int[] numbers)
    {
        _numbers = numbers;
    }

    public static Finder CreateInstance(params int[] numbers)
    {
        return new Finder(numbers);
    }

    public int Min()
    {
        return Numbers.Min();
    }
}