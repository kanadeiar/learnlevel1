namespace Task1MinimalNumberTests.MinimalNumber;

public class FinderTests
{
    [Theory, MemberData(nameof(ValuesSource), "")]
    public void TestData(int[] numbers)
    {
        ICommonFinder finder = new Finder(numbers);

        var actuals = finder.Numbers.ToArray();

        actuals.Should().Equal(numbers);
    }

    [Theory, MemberData(nameof(ValuesSource), "min")]
    public void TestMinimal(int[] numbers, int expected)
    {
        IMinFinder finder = new Finder(numbers);

        var actual = finder.Min();

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> ValuesSource(string type)
    {
        switch (type)
        {
            case "min":
                yield return new object[] { new int[] { 3, 4, int.MaxValue }, 3 };
                yield return new object[] { new int[] { 0, int.MinValue, -5 }, int.MinValue };
                break;
            default:
                yield return new object[] { new int[] { 3, 4, 5 } };
                break;
        }
    }
}