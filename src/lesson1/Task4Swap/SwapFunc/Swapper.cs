namespace Task4Swap.SwapFunc;

public class Swapper : ICommonSwapper
{
    private readonly Values _values;
    
    public int First => _values.First;

    public int Second => _values.Second;

    private SwapCode? _code;

    public Swapper(int first, int second)
    {
        _values = new Values(first, second);
    }

    public void Swap(SwapType type)
    {
        _code = SwapCode.FromType(type);
        _code.Swap(_values);
    }
}