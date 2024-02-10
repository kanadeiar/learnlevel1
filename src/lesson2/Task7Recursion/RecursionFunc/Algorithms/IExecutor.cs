namespace Task7Recursion.RecursionFunc.Algorithms;

public interface IExecutor<out T>
{
    T RecursiveExecute(int a, int b);
}