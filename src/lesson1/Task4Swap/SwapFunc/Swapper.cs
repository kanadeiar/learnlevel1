namespace Task4Swap.SwapFunc;

public class Swapper : ICommonSwapper
{
    private readonly Values _values;
    
    public int First => _values.First;

    public int Second => _values.Second;

    private SwapCode? _code;

    private Swapper(int first, int second)
    {
        _values = new Values
        {
            First = first, 
            Second = second
        };
    }

    public static Swapper Create(int first, int second)
    {
        return new Swapper(first, second);
    }

    public void Swap(SwapType type)
    {
        _code = SwapCode.FromType(type);
        _code.Swap(_values);
    }
}