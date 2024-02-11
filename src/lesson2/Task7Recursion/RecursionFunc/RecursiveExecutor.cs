namespace Task7Recursion.RecursionFunc;

public class RecursiveExecutor
{
    public static IExecutor<T> Create<T>(AlgorithmCode code)
    {
        switch (code)
        {
            case AlgorithmCode.Text:
                return (IExecutor<T>)new MessageExecutor();
            case AlgorithmCode.Sum:
                return (IExecutor<T>)new SumExecutor();
            default:
                throw new IndexOutOfRangeException(nameof(code));
        }
    }
}