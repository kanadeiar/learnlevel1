namespace Lesson1Swap.SwapFunc;

public class Swapper
{
    private int _first;

    public int First
    {
        get => _first;
        set => _first = value;
    }

    private int _second;

    public int Second
    {
        get => _second;
        set => _second = value;
    }

    private Swapper(int first, int second)
    {
        _first = first;
        _second = second;
    }
    public static Swapper Create(int first, int second)
    {
        return new Swapper(first, second);
    }
}