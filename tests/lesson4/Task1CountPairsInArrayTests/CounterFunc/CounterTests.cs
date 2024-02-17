using Task1CountPairsInArray.CounterFunc;

namespace Task1CountPairsInArrayTests.CounterFunc;

public class CounterTests
{
    [Theory, MemberData(nameof(NumbersSource))]
    public void TestCount(int[] numbers, int expected)
    {
        var counter = new Counter();

        var actual = counter.Count(numbers);

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> NumbersSource()
    {
        yield return new object[] { new int[] { 9, -3, 6, 9 }, 0 };
        yield return new object[] { new int[] { 6, 2, 9, -3, 6 }, 2 };
        yield return new object[] { new int[] { 1, 3, 9, -3, 1, 9 }, 3 };
    }
}