namespace Task2BodyMassIndex.BodyMassIndexModule.FormulaFeat;

public class Formula
{
    private readonly double _weight;
    private readonly double _height;

    protected double Weight => _weight;
    protected double Height => _height;

    protected Formula(double weight, double height)
    {
        _weight = weight;
        _height = height;
    }

    public static Formula Create(FormulaCode code, double weight, double height)
    {
        switch (code)
        {
            case FormulaCode.Simple:
                return new SimpleFormula(weight, height);
            default:
                return new Formula(weight, height);
        }
    }

    public virtual double Calculate()
    {
        return default;
    }
}