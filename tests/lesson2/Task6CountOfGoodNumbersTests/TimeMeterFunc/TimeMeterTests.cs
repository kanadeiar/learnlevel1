using Task6CountOfGoodNumbers.TimeMeterFunc;

namespace Task6CountOfGoodNumbersTests.TimeMeterFunc;

public class TimeMeterTests
{
    [Fact]
    public void TestStart()
    {
        var expected = DateTime.Now;
        var meter = (TimeMeter)TimeMeter.Start();

        var actual = meter.Current;

        Assert.Equal(expected, actual, TimeSpan.FromMilliseconds(10));
    }

    [Fact]
    public async Task TestStop()
    {
        var expected = DateTime.Now;
        IStoppingMeter meter = TimeMeter.Start();
        await Task.Delay(TimeSpan.FromSeconds(1));

        var actual = meter.Stop();

        Assert.Equal(expected.AddSeconds(1), expected.Add(actual), TimeSpan.FromMilliseconds(10));
    }
}