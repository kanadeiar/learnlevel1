namespace Task2FuncMinimumTests.FuncModule;

public class FuncSourceTests
{
    [Theory, MemberData(nameof(FuncNamesSource))]
    public void TestGetFunc(FuncCode code, double x, double expected)
    {
        var func = FuncSource.GetFunc(code);

        var actual = func(x);

        actual.Should().BeApproximately(expected, 0.01);
    }

    public static IEnumerable<object[]> FuncNamesSource()
    {
        yield return [FuncCode.Multiply, 3, 9];
        yield return [FuncCode.Triple, 3, 27];
        yield return [FuncCode.Sin, 3, 0.14];
        yield return [FuncCode.Formula, 3, -91];
    }
}