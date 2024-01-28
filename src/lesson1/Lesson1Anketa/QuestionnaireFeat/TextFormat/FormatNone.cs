namespace Lesson1Questionnaire.QuestionnaireFeat.TextFormat;

public class FormatNone : FormatBase
{
    public override TextFormatCode GetCode()
    {
        return TextFormatCode.None;
    }

    public override string GetText(IPropertiesQuestionnaire questionnaire)
    {
        return string.Empty;
    }
}