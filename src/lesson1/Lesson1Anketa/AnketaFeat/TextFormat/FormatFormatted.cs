namespace Lesson1Anketa.AnketaFeat.TextFormat;

public class FormatFormatted : FormatBase
{
    public override TextFormatType GetCode()
    {
        return TextFormatType.Formatted;
    }

    public override string GetText(IPropertiesAnketa anketa)
    {
        return string.Format("Formatted {0} {1} {2} лет {3} см {4} кг", anketa.SurName, anketa.Name, anketa.Age, anketa.Height, anketa.Weight);
    }
}