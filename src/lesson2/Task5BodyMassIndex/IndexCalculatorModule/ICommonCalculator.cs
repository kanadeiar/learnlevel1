namespace Task5BodyMassIndex.IndexCalculatorModule;

public interface ICommonCalculator : IDataCalculator, IIndexCalculator, IPrintingCalculator
{

}

public interface IDataCalculator
{
    double Weight { get; }
    double Height { get; }
}

public interface IIndexCalculator
{
    double Index();
}

public interface IPrintingCalculator
{
    string Print();
}