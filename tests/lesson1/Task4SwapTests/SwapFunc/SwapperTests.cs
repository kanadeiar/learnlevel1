using Task4Swap.SwapFunc;
using Task4Swap.SwapFunc.SwapImpl;

namespace Task4SwapTests.SwapFunc;

public class SwapperTests
{
    [Fact]
    public void TestData()
    {
        var swapper = new Swapper(5, 6);

        Assert.Equal(5, swapper.First);
        Assert.Equal(6, swapper.Second);
    }

    [Fact]
    public void SimpleSwap()
    {
        var swapper = new Swapper(2, 3);

        swapper.Swap(SwapType.WithBuffer);

        Assert.Equal(3, swapper.First);
        Assert.Equal(2, swapper.Second);
    }

    [Fact]
    public void AdvanvedSwap()
    {
        var swapper = new Swapper(2, 3);

        swapper.Swap(SwapType.Advanced);

        Assert.Equal(3, swapper.First);
        Assert.Equal(2, swapper.Second);
    }
}