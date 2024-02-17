namespace Task1CountPairsInArray.ArrayCounterFunc;

public class Generator
{
    private readonly Random _random = new Random();

    public IEnumerable<int> Generate(int count)
    {
        var result = Enumerable.Range(1, count)
            .Select(a => _random.Next(-10_000, 10_000));
        return result;
    }
}