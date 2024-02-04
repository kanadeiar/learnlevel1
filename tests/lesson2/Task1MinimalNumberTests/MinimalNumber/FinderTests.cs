namespace Task1MinimalNumberTests.MinimalNumber;

public class FinderTests
{
    [Fact]
    public void TestData()
    {
        int[] numbers = new[] { 3, 4, 5 };
        ICommonFinder finder = new Finder(numbers);

        var actuals = finder.Numbers.ToArray();

        Assert.Equal(3, actuals.Length);
        Assert.Equal(3, actuals[0]);
        Assert.Equal(4, actuals[1]);
        Assert.Equal(5, actuals[2]);
    }

    [Theory]
    [InlineData(3, 4, int.MaxValue, 3)]
    [InlineData(0, int.MinValue, -5, int.MinValue)]
    public void TestMinimal(int first, int second, int third, int expected)
    {
        int[] numbers = new[] { first, second, third };
        IMinFinder finder = new Finder(numbers);

        var actual = finder.Min();

        Assert.Equal(expected, actual);
    }
}