namespace Task2BodyMassIndex.BodyMassIndexModule.FormulaFeat;

public class SimpleFormula : Formula
{
    public SimpleFormula(double weight, double height) : base(weight, height)
    {
    }

    public override double Calculate()
    {
        return Weight / Height * Height;
    }
}