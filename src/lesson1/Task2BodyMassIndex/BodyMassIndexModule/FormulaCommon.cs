namespace Task2BodyMassIndex.BodyMassIndexModule;

internal class FormulaCommon
{
    private readonly double _weight;
    private readonly double _height;

    public FormulaCommon(double weight, double height)
    {
        _weight = weight;
        _height = height;
    }

    public double Calculate()
    {
        var result = _weight / (_height * _height);
        return result;
    }
}