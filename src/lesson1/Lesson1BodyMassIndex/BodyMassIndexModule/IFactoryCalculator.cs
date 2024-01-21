namespace Lesson1BodyMassIndex.BodyMassIndexModule;

public interface IFactoryCalculator : ICommonCalculator, IPrintingCalculator
{
    
}

public interface ICommonCalculator
{
    double Weight { get; set; }
    double Height { get; set; }
}

public interface IPrintingCalculator
{
    string Print();
}