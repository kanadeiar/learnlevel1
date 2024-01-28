namespace Task4Swap.SwapFunc.SwapImpl;

public class WithBufferCode : SwapCode
{
    public override void Swap(Values values)
    {
        var buffer = values.First;
        values.First = values.Second;
        values.Second = buffer;
    }
}