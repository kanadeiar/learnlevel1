namespace Task1QuestionnaireTests.QuestionnaireFeat;

public class QuestionnaireTests
{
    [Theory, MemberData(nameof(QuestionnaireSource))]
    public void TestData(Questionnaire questionnaire)
    {
        questionnaire.Name.Should().Be("Test1");
        questionnaire.SurName.Should().Be("TestFam1");
        questionnaire.Age.Should().Be(10);
        questionnaire.Height.Should().Be(80);
        questionnaire.Weight.Should().Be(49);
    }

    [Theory, MemberData(nameof(QuestionnaireSource))]
    public void TestGluedLine(Questionnaire questionnaire)
    {
        var actual = questionnaire.GetText(TextFormatCode.GluedLine);

        questionnaire.Code.Should().Be(TextFormatCode.GluedLine);
        actual.Should().Be("TestFam1 Test1 10 лет 80 см 49 кг");
    }

    [Theory, MemberData(nameof(QuestionnaireSource))]
    public void TestFormattedLine(Questionnaire questionnaire)
    {
        var actual = questionnaire.GetText(TextFormatCode.Formatted);

        questionnaire.Code.Should().Be(TextFormatCode.Formatted);
        actual.Should().Be("Formatted TestFam1 Test1 10 лет 80 см 49 кг");
    }

    [Theory, MemberData(nameof(QuestionnaireSource))]
    public void TestInterpolated(Questionnaire questionnaire)
    {
        var actual = questionnaire.GetText(TextFormatCode.Interpolated);

        questionnaire.Code.Should().Be(TextFormatCode.Interpolated);
        actual.Should().Be("TestFam1 Test1 10 лет 80 см 49 кг");
    }

    [Theory, MemberData(nameof(QuestionnaireSource))]
    public void TestFormatNone(Questionnaire questionnaire)
    {
        var actual = questionnaire.GetText(TextFormatCode.None);

        questionnaire.Code.Should().Be(TextFormatCode.None);
        actual.Should().BeEmpty();
    }

    public static IEnumerable<object[]> QuestionnaireSource()
    {
        foreach (var values in QuestionnaireValuesSource())
        {
            yield return new object[]
                { new Questionnaire((string)values[0], (string)values[1], (int)values[2], (int)values[3], (int)values[4]) };
        }
    }

    public static IEnumerable<object[]> QuestionnaireValuesSource()
    {
        yield return new object[] { "Test1", "TestFam1", 10, 80, 49 };
    }
}