namespace Task5BodyMassIndex.IndexCalculatorModule;

public class Calculator : ICommonCalculator
{
    private readonly double _weight;

    public double Weight => _weight;
    
    private readonly double _height;
    
    public double Height => _height;

    public Calculator(double weight, double height)
    {
        _weight = weight;
        _height = height;
    }

    public string Print()
    {
        var index = simpleFormula();
        return $"Индекс массы тела = {index.ToString("F1", NumberFormatInfo.InvariantInfo)}";
    }

    private double simpleFormula()
    {
        return Weight / (Height * Height);
    }
}