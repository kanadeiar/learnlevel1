namespace Lesson1Anketa.AnketaFeat.TextFormat;

public abstract class FormatBase
{
    public static FormatBase Create(TextFormatType typ)
    {
        switch (typ)
        {
            case TextFormatType.GluedLine:
                return new FormatGluedLine();
            case TextFormatType.Formatted:
                return new FormatFormatted();
            case TextFormatType.Interpolated:
                return new FormatInterpolated();
            default:
                throw new IndexOutOfRangeException();
        }
    }

    public abstract TextFormatType GetCode();

    public abstract string GetText(IPropertiesAnketa anketa);
}