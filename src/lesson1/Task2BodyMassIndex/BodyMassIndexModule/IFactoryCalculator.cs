namespace Task2BodyMassIndex.BodyMassIndexModule;

public interface IFactoryCalculator : ICommonCalculator, IPrintingCalculator
{
    
}

public interface ICommonCalculator
{
    double Weight { get; }
    double Height { get; }
}

public interface IPrintingCalculator
{
    string Print();
}