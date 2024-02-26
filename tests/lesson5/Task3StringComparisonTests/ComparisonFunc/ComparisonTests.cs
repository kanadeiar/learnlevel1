namespace Task3StringComparisonTests.ComparisonFunc;

public class ComparisonTests
{
    [Theory, MemberData(nameof(WordsSource))]
    public void TestShuffleComparison(string first, string second, bool expected)
    {
        var actual = Comparison.ShuffleComparison(first, second);

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> WordsSource()
    {
        yield return ["badc", "abcd", true];
        yield return ["в4ыа1фв2аaaa", "аывфвaaaа124", true];
        yield return ["ytrewq", "qwerty", true];
        yield return ["badcs", "aabcd", false];
        yield return ["ba", "ass1123abcd", false];
    }
}