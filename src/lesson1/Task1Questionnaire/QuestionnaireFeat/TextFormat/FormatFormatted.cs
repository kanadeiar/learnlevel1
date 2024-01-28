namespace Task1Questionnaire.QuestionnaireFeat.TextFormat;

public class FormatFormatted : FormatBase
{
    public override TextFormatCode GetCode()
    {
        return TextFormatCode.Formatted;
    }

    public override string GetText(IPropertiesQuestionnaire questionnaire)
    {
        return string.Format("Formatted {0} {1} {2} лет {3} см {4} кг", questionnaire.SurName, questionnaire.Name, questionnaire.Age, questionnaire.Height, questionnaire.Weight);
    }
}