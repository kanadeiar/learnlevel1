namespace Task7Recursion.RecursionFunc.Algorithms;

public class SumExecutor : IExecutor<long>
{
    public long RecursiveExecute(int a, int b)
    {
        if (a == b) return a;
        return a + RecursiveExecute(a + 1, b);
    }
}