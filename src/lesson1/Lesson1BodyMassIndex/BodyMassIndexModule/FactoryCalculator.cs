﻿namespace Lesson1BodyMassIndex.BodyMassIndexModule;

public class FactoryCalculator : IFactoryCalculator
{
    private double _weight;

    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }

    private double _height;

    public double Height
    {
        get => _height;
        set => _height = value;
    }

    public string Print()
    {
        var formula = new FormulaCommon(Weight, Height);
        var index = formula.Calculate();
        return $"Индекс массы тела = {index:F1}";
    }

    public static IFactoryCalculator Create()
    {
        return new FactoryCalculator();
    }
}