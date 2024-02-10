namespace Task7RecursionTests.RecursionFunc;

public class RecursiveExecutorTests
{
    [Fact]
    public void TestRecursiveExecute()
    {
        var executor = RecursiveExecutor.Create<string>(AlgorithmCode.Text);

        var actual = executor.RecursiveExecute(1, 10);

        Assert.Equal("1 2 3 4 5 6 7 8 9 10", actual);
    }

    [Fact]
    public void TestRecursiveSum()
    {
        var executor = RecursiveExecutor.Create<long>(AlgorithmCode.Sum);

        var actual = executor.RecursiveExecute(1, 10);

        Assert.Equal(55L, actual);
    }
}