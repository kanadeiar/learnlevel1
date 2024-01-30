namespace Task2BodyMassIndex.BodyMassIndexModule;

public class Calculator : ICommonCalculator
{
    private double _weight;

    public double Weight
    {
        get => _weight;
    }

    private double _height;

    public double Height
    {
        get => _height;
    }

    public Calculator(double weight, double height)
    {
        _weight = weight;
        _height = height;
    }

    public static ICommonCalculator Create(double weight, double height)
    {
        return new Calculator(weight, height);
    }

    public string Print()
    {
        var formula = new FormulaCommon(Weight, Height);
        var index = formula.Calculate().ToString("F1", NumberFormatInfo.InvariantInfo);
        return $"Индекс массы тела = {index}";
    }
}