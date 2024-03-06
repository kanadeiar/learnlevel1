using FluentAssertions;

namespace Task2BodyMassIndexTests.BodyMassIndexModule;

public class CalculatorTests
{
    [Theory, MemberData(nameof(ValuesSource))]
    public void TestGetIndex(double weight, double height, string expected)
    {
        IPrintingCalculator calculator = new Calculator(weight, height);

        var actual = calculator.Print();

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> ValuesSource()
    {
        yield return new object[] { 50.0, 1.700, "Индекс массы тела = 17.3" };
        yield return new object[] { 80.0, 1.800, "Индекс массы тела = 24.7" };
        yield return new object[] { 85.0, 1.800, "Индекс массы тела = 26.2" };
    }
}