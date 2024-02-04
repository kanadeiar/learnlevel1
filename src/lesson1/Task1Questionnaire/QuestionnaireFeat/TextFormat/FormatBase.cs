namespace Task1Questionnaire.QuestionnaireFeat.TextFormat;

public abstract class FormatBase
{
    public static FormatBase Create(TextFormatCode typ)
    {
        switch (typ)
        {
            case TextFormatCode.GluedLine:
                return new FormatGluedLine();
            case TextFormatCode.Formatted:
                return new FormatFormatted();
            case TextFormatCode.Interpolated:
                return new FormatInterpolated();
            default:
                return new FormatNone();
        }
    }

    public abstract TextFormatCode GetCode();

    public abstract string GetText(IDataQuestionnaire questionnaire);
}