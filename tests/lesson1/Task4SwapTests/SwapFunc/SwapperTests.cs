namespace Task4SwapTests.SwapFunc;

public class SwapperTests
{
    [Theory, MemberData(nameof(ValuesSource))]
    public void TestValues(int first, int second)
    {
        var swapper = new Swapper(first, second);

        Assert.Equal(first, swapper.First);
        Assert.Equal(second, swapper.Second);
    }

    [Theory, MemberData(nameof(ValuesSource))]
    public void TestWithBufferSwap(int first, int second)
    {
        var swapper = new Swapper(first, second);

        swapper.Swap(SwapType.WithBuffer);

        Assert.Equal(second, swapper.First);
        Assert.Equal(first, swapper.Second);
    }

    [Theory, MemberData(nameof(ValuesSource))]
    public void TestAdvancedSwap(int first, int second)
    {
        var swapper = new Swapper(first, second);

        swapper.Swap(SwapType.Advanced);

        Assert.Equal(second, swapper.First);
        Assert.Equal(first, swapper.Second);
    }

    public static IEnumerable<object[]> ValuesSource()
    {
        yield return new object[] { 2, 3 };
    }
}