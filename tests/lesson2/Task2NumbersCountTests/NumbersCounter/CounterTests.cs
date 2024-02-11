namespace Task2NumbersCountTests.NumbersCounter;

public class CounterTests
{
    [Fact]
    public void TestData()
    {
        IDataCounter counter = new Counter(100);

        counter.Number.Should().Be(100);
    }

    [Theory, MemberData(nameof(ValuesSource))]
    public void TestGetCount(int number, int expected)
    {
        ICountCounter counter = new Counter(number);

        var actual = counter.GetCount();

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> ValuesSource()
    {
        yield return new object[] { 1, 1 };
        yield return new object[] { 100, 3 };
    }
}