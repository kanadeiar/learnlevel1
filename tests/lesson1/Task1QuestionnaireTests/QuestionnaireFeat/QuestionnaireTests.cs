using Task1Questionnaire.QuestionnaireFeat;
using Task1Questionnaire.QuestionnaireFeat.TextFormat;

namespace Task1QuestionnaireTests.QuestionnaireFeat;

public class QuestionnaireTests
{
    private ICommonQuestionnaire _questionnaire;

    public QuestionnaireTests()
    {
        _questionnaire = Questionnaire.Create("Test1", "TestFam1", 10, 80, 49);
    }

    [Fact]
    public void TestData()
    {
        Assert.Equal("Test1", _questionnaire.Name);
        Assert.Equal("TestFam1", _questionnaire.SurName);
        Assert.Equal(10, _questionnaire.Age);
        Assert.Equal(80, _questionnaire.Height);
        Assert.Equal(49, _questionnaire.Weight);
    }

    [Fact]
    public void TestFormatNone()
    {
        var actual = _questionnaire.GetText(TextFormatCode.None);

        Assert.Equal(TextFormatCode.None, _questionnaire.Code);
        Assert.Equal(string.Empty, actual);
    }

    [Fact]
    public void TestGluedLine()
    {
        var actual = _questionnaire.GetText(TextFormatCode.GluedLine);

        Assert.Equal(TextFormatCode.GluedLine, _questionnaire.Code);
        Assert.Equal("TestFam1 Test1 10 лет 80 см 49 кг", actual);
    }

    [Fact]
    public void TestFormattedLine()
    {
        var actual = _questionnaire.GetText(TextFormatCode.Formatted);

        Assert.Equal(TextFormatCode.Formatted, _questionnaire.Code);
        Assert.Equal("Formatted TestFam1 Test1 10 лет 80 см 49 кг", actual);
    }

    [Fact]
    public void TestInterpolated()
    {
        var actual = _questionnaire.GetText(TextFormatCode.Interpolated);

        Assert.Equal(TextFormatCode.Interpolated, _questionnaire.Code);
        Assert.Equal("TestFam1 Test1 10 лет 80 см 49 кг", actual);
    }
}