namespace Task2StaticClass.StaticCounterFunc.Internal;

internal class Generator
{
    private Random _random = new Random();

    public IEnumerable<int> GenerateRandomArray(int count)
    {
        var result = Enumerable.Range(1, count)
            .Select(a => _random.Next(-10_000, 10_000));
        return result;
    }
}