namespace Task1Questionnaire.QuestionnaireFeat.TextFormat;

public class FormatInterpolated : FormatBase
{
    public override TextFormatCode GetCode()
    {
        return TextFormatCode.Interpolated;
    }

    public override string GetText(IDataQuestionnaire questionnaire)
    {
        return $"{questionnaire.SurName} {questionnaire.Name} {questionnaire.Age} лет {questionnaire.Height} см {questionnaire.Weight} кг";
    }
}