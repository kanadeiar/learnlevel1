namespace Task2FuncMinimum.FuncModule;

public static class FuncSource
{
    private static readonly DataSaver.Func[] _funcs;

    static FuncSource()
    {
        _funcs =
        [
            d => d * d,
            d => d * d * d,
            Math.Sin,
            d => d * d - 50 * d + 50,
        ];
    }

    public static DataSaver.Func GetFunc(FuncCode code)
    {
        return code switch
        {
            FuncCode.Multiply => _funcs[0],
            FuncCode.Triple => _funcs[1],
            FuncCode.Sin => _funcs[2],
            FuncCode.Formula => _funcs[3],
            _ => throw new IndexOutOfRangeException(nameof(code))
        };
    }
}

public enum FuncCode
{
    Multiply,
    Triple,
    Sin,
    Formula,
}