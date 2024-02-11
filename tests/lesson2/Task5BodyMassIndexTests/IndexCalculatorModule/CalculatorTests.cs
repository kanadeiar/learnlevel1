namespace Task5BodyMassIndexTests.IndexCalculatorModule;

public class CalculatorTests
{
    [Theory, MemberData(nameof(CalculatorSource), "text")]
    public void TestPrint(double weight, double height, string expected)
    {
        var calculator = (ICommonCalculator)new Calculator(weight, height);

        var actual = calculator.Print();

        actual.Should().Be(expected);
    }

    [Theory, MemberData(nameof(CalculatorSource), "")]
    public void TestIndex(double weight, double height, double expected)
    {
        var calculator = (ICommonCalculator)new Calculator(weight, height);

        var actual = calculator.Index();

        actual.Should().BeApproximately(expected, 0.1);
    }

    public static IEnumerable<object[]> CalculatorSource(string type)
    {
        switch (type)
        {
            case "text":
                yield return new object[] { 50.0, 1.700, "Индекс массы тела = 17.3" };
                yield return new object[] { 80.0, 1.800, "Индекс массы тела = 24.7" };
                yield return new object[] { 85.0, 1.800, "Индекс массы тела = 26.2" };
                break;
            default:
                yield return new object[] { 50.0, 1.700, 17.3 };
                yield return new object[] { 80.0, 1.800, 24.7 };
                yield return new object[] { 85.0, 1.800, 26.2 };
                break;
        }
    }
}