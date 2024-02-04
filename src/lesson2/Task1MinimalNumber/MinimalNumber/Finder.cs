namespace Task1MinimalNumber.MinimalNumber;

public class Finder : ICommonFinder
{
    private readonly int[] _numbers;

    public IEnumerable<int> Numbers => _numbers;

    public Finder(int[] numbers)
    {
        _numbers = numbers;
    }

    public int Min()
    {
        return Numbers.Min();
    }
}