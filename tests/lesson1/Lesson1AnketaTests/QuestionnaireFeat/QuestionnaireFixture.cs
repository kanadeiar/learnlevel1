using Lesson1Questionnaire.QuestionnaireFeat;

namespace Lesson1QuestionnaireTests.QuestionnaireFeat;

public class QuestionnaireFixture : IDisposable
{
    public IFaсtoryquestionnaire Ank;

    public QuestionnaireFixture()
    {
        Ank = Questionnaire.Create("Test1", "TestFam1", 10, 80, 49);
    }

    public void Dispose()
    {
        Ank = null!;
    }
}