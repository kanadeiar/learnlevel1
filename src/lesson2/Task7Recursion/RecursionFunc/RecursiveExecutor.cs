namespace Task7Recursion.RecursionFunc;

public class RecursiveExecutor
{
    public static IExecutor<T> Create<T>(AlgorithmCode code)
    {
        switch (code)
        {
            case AlgorithmCode.Text:
                return new MessageExecutor() as IExecutor<T>;
            case AlgorithmCode.Sum:
                return new SumExecutor() as IExecutor<T>;
            default:
                throw new IndexOutOfRangeException(nameof(code));
        }
    }
}