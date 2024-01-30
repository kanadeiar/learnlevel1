namespace Task1Questionnaire.QuestionnaireFeat;

public interface ICommonQuestionnaire : IDataQuestionnaire, IGettingTextQuestionnaire
{
    TextFormatCode Code { get; }
}

public interface IDataQuestionnaire
{
    string? Name { get; }
    string? SurName { get; }
    int Age { get; }
    int Height { get; }
    int Weight { get; }
}

public interface IGettingTextQuestionnaire
{
    string GetText(TextFormatCode typ);
}