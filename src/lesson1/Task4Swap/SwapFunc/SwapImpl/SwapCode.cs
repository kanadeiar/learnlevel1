namespace Task4Swap.SwapFunc.SwapImpl;

public abstract class SwapCode
{
    public abstract void Swap(Values values);

    public static SwapCode FromType(SwapType type)
    {
        switch (type)
        {
            case SwapType.WithBuffer:
                return new WithBufferCode();
            case SwapType.Advanced:
                return new AdvancedCode();
            default:
                throw new ArgumentOutOfRangeException(nameof(type));
        }
    }
}