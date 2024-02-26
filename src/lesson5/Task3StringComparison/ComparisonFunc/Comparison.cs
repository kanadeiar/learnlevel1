namespace Task3StringComparison.ComparisonFunc;

public class Comparison
{
    public static bool ShuffleComparison(string first, string second)
    {
        var orderedFirst = string.Join("", first.OrderBy(c => c).ToArray());
        var orderedSecond = string.Join("", second.OrderBy(c => c).ToArray());
        return orderedFirst.Equals(orderedSecond);
    }
}