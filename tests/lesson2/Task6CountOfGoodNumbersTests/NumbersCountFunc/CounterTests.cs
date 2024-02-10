namespace Task6CountOfGoodNumbersTests.NumbersCountFunc;

public class CounterTests
{
    [Fact]
    public void TestCount()
    {
        var counter = new Counter();

        var actual = counter.Count(1_000_000);

        Assert.Equal(43654768809, actual);
    }
}