namespace Lesson1Questionnaire.QuestionnaireFeat;

public interface IFaсtoryquestionnaire : IPropertiesQuestionnaire, ITextGeneratingQuestionnaire
{
    TextFormatCode Code { get; }
}

public interface IPropertiesQuestionnaire
{
    string? Name { get; }
    string? SurName { get; }
    int Age { get; }
    int Height { get; }
    int Weight { get; }
}

public interface ITextGeneratingQuestionnaire
{
    string GetText(TextFormatCode typ);
}