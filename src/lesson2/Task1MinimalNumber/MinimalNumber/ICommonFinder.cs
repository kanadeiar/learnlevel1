namespace Task1MinimalNumber.MinimalNumber;

public interface ICommonFinder : IMinFinder
{
    IEnumerable<int> Numbers { get; }
}

public interface IMinFinder
{
    int Min();
}