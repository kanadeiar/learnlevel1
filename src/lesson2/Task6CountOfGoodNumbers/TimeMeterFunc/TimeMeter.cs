namespace Task6CountOfGoodNumbers.TimeMeterFunc;

public class TimeMeter : IStoppingMeter
{
    private DateTime _start;

    public static IStoppingMeter Start()
    {
        var meter = new TimeMeter();
        meter.start();
        return meter;
    }

    private void start()
    {
        _start = DateTime.Now;
    }

    public TimeSpan Stop()
    {
        var result = DateTime.Now - _start;
        return result;
    }

    public DateTime Current => _start;
}