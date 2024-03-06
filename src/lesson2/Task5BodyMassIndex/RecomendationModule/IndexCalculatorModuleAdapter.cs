namespace Task5BodyMassIndex.RecomendationModule;

public class IndexCalculatorModuleAdapter
{
    private readonly ICommonCalculator _calculator;

    public double Weight => _calculator.Weight;
    public double Height => _calculator.Height;

    public IndexCalculatorModuleAdapter(ICommonCalculator calculator)
    {
        _calculator = calculator;
    }

    public double Index() => _calculator.Index();

    public string Print() => _calculator.Print();
}