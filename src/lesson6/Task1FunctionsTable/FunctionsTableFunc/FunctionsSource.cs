namespace Task1FunctionsTable.FunctionsTableFunc;

public static class FunctionsSource
{
    public delegate double Fun(double a, double x);

    public static Fun GetFunction(FunCode code)
    {
        return code switch
        {
            FunCode.Multiply => (_, x) => x * x * x,
            FunCode.Square => (a, x) => a * Math.Pow(x, 2),
            FunCode.Sin => (a, x) => a * Math.Sin(x),
            _ => throw new IndexOutOfRangeException(nameof(code))
        };
    }
}

public enum FunCode
{
    Multiply,
    Square,
    Sin,
}

