namespace Task7Recursion.RecursionFunc.Algorithms;

public class MessageExecutor : IExecutor<string>
{
    public string RecursiveExecute(int a, int b)
    {
        if (a == b) return b.ToString();
        return $"{a} {RecursiveExecute(a + 1, b)}";
    }
}