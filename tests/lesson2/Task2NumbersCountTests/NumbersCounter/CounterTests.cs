using Task2NumbersCount.NumbersCounter;

namespace Task2NumbersCountTests.NumbersCounter;

public class CounterTests
{
    [Fact]
    public void TestData()
    {
        IDataCounter counter = Counter.Create(100);

        Assert.Equal(100, counter.Number);
    }
}