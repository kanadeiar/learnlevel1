namespace Lesson1Anketa.AnketaFeat.TextFormat;

public class FormatGluedLine : FormatBase
{
    public override TextFormatType GetCode()
    {
        return TextFormatType.GluedLine;
    }

    public override string GetText(IPropertiesAnketa anketa)
    {
        return anketa.SurName + " " + anketa.Name + " " + anketa.Age + " лет " + anketa.Height + " см " + anketa.Weight + " кг";
    }
}