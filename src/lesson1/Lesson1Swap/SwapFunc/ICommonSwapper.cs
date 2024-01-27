using Lesson1Swap.SwapFunc.SwapImpl;

namespace Lesson1Swap.SwapFunc;

public interface ICommonSwapper : ISwapping
{
    int First { get; }
    int Second { get; }
}

public interface ISwapping
{
    void Swap(SwapType type);
}