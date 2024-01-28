namespace Task4Swap.SwapFunc.SwapImpl;

public class AdvancedCode : SwapCode
{
    public override void Swap(Values values)
    {
        values.First = values.First - values.Second;
        values.Second = values.First + values.Second;
        values.First = -values.First + values.Second;
    }
}