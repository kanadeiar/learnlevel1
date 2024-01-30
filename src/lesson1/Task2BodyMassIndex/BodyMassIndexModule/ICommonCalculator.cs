namespace Task2BodyMassIndex.BodyMassIndexModule;

public interface ICommonCalculator : IDataCalculator, IPrintingCalculator
{
    
}

public interface IDataCalculator
{
    double Weight { get; }
    double Height { get; }
}

public interface IPrintingCalculator
{
    string Print();
}