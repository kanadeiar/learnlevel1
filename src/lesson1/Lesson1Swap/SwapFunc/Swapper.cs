using Lesson1Swap.SwapFunc.SwapImpl;

namespace Lesson1Swap.SwapFunc;

public class Swapper
{
    private readonly Values _values;
    
    public int First
    {
        get => _values.First;
        set => _values.First = value;
    }

    public int Second
    {
        get => _values.Second;
        set => _values.Second = value;
    }

    private SwapCode _code;

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