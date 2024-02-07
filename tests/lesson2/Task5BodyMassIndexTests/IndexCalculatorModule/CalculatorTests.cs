namespace Task5BodyMassIndexTests.IndexCalculatorModule;

public class CalculatorTests
{
    [Theory, MemberData(nameof(CalculatorSource))]
    public void TestPrint(double weight, double height, string expected)
    {
        var calculator = (ICommonCalculator)new Calculator(weight, height);

        var actual = calculator.Print();
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> CalculatorSource()
    {
        yield return new object[] { 50.0, 1.700, "Индекс массы тела = 17.3" };
        yield return new object[] { 80.0, 1.800, "Индекс массы тела = 24.7" };
        yield return new object[] { 85.0, 1.800, "Индекс массы тела = 26.2" };
    }

    [Theory, MemberData(nameof(CalculatorIndexSource))]
    public void TestIndex(double weight, double height, double expected)
    {
        var calculator = (ICommonCalculator)new Calculator(weight, height);

        var actual = calculator.Index();
        Assert.Equal(expected, actual, 0.01);
    }

    public static IEnumerable<object[]> CalculatorIndexSource()
    {
        yield return new object[] { 50.0, 1.700, 17.3 };
        yield return new object[] { 80.0, 1.800, 24.7 };
    }
}