using Lesson1Questionnaire.QuestionnaireFeat;
using Lesson1Questionnaire.QuestionnaireFeat.TextFormat;

namespace Lesson1QuestionnaireTests.QuestionnaireFeat;

public class QuestionnaireTests : IClassFixture<QuestionnaireFixture>
{
    private IFaсtoryquestionnaire _anketa;

    public QuestionnaireTests(QuestionnaireFixture fixture)
    {
        _anketa = fixture.Ank;
    }

    [Fact]
    public void TestData()
    {
        _anketa = Questionnaire.Create("Test", "TestFam", 20, 180, 79);

        Assert.Equal("Test", _anketa.Name);
        Assert.Equal("TestFam", _anketa.SurName);
        Assert.Equal(20, _anketa.Age);
        Assert.Equal(180, _anketa.Height);
        Assert.Equal(79, _anketa.Weight);
    }

    [Fact]
    public void TestFormatNone()
    {
        var actual = _anketa.GetText(TextFormatCode.None);

        Assert.Equal(TextFormatCode.None, _anketa.Code);
        Assert.Equal(String.Empty, actual);
    }

    [Fact]
    public void TestGluedLine()
    {
        var actual = _anketa.GetText(TextFormatCode.GluedLine);

        Assert.Equal(TextFormatCode.GluedLine, _anketa.Code);
        Assert.Equal("TestFam1 Test1 10 лет 80 см 49 кг", actual);
    }

    [Fact]
    public void TestFormattedLine()
    {
        var actual = _anketa.GetText(TextFormatCode.Formatted);

        Assert.Equal(TextFormatCode.Formatted, _anketa.Code);
        Assert.Equal("Formatted TestFam1 Test1 10 лет 80 см 49 кг", actual);
    }

    [Fact]
    public void TestInterpolated()
    {
        var actual = _anketa.GetText(TextFormatCode.Interpolated);

        Assert.Equal(TextFormatCode.Interpolated, _anketa.Code);
        Assert.Equal("TestFam1 Test1 10 лет 80 см 49 кг", actual);
    }
}