namespace Lesson1Anketa.AnketaFeat.TextFormat;

public class FormatNull : FormatBase
{
    public override TextFormatCode GetCode()
    {
        return TextFormatCode.None;
    }

    public override string GetText(IPropertiesAnketa anketa)
    {
        return string.Empty;
    }
}