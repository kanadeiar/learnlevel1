﻿using Task2BodyMassIndex.BodyMassIndexModule;

namespace Task2BodyMassIndexTests.BodyMassIndexModule;

public class CalculatorTests
{
    [Theory, MemberData(nameof(DataForTest))]
    public void TestGetIndex(double weight, double height, string expected)
    {
        var calculator = Calculator.Create(weight, height);

        var actual = calculator.Print();

        Assert.Equal(expected, actual);
    }

    public static TheoryData<double, double, string> DataForTest = new()
    {
        { 50.0, 1.700, "Индекс массы тела = 17.3" },
        { 80.0, 1.800, "Индекс массы тела = 24.7" },
        { 85.0, 1.800, "Индекс массы тела = 26.2" },
    };
}