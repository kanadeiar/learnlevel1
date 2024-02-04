namespace Task1Questionnaire.QuestionnaireFeat.TextFormat;

public class FormatGluedLine : FormatBase
{
    public override TextFormatCode GetCode()
    {
        return TextFormatCode.GluedLine;
    }

    public override string GetText(IDataQuestionnaire questionnaire)
    {
        return questionnaire.SurName + " " + questionnaire.Name + " " + questionnaire.Age + " лет " + questionnaire.Height + " см " + questionnaire.Weight + " кг";
    }
}