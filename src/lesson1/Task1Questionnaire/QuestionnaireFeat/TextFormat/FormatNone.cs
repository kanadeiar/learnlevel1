namespace Task1Questionnaire.QuestionnaireFeat.TextFormat;

public class FormatNone : FormatBase
{
    public override TextFormatCode GetCode()
    {
        return TextFormatCode.None;
    }

    public override string GetText(IDataQuestionnaire questionnaire)
    {
        return string.Empty;
    }
}