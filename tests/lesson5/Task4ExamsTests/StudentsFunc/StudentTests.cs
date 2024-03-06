namespace Task4ExamsTests.StudentsFunc;

public class StudentTests
{
    [Theory, MemberData(nameof(NameSource))]
    public void TestData(string surname, string name, int[] valuations)
    {
        var expected = "Тестов Тест - 4.00";
        ICommonStudent student = new Student(surname, name, valuations);

        var actual = student.ToString();

        actual.Should().Be(expected);
    }

    [Theory, MemberData(nameof(NameSource))]
    public void TestAverage(string surname, string name, int[] valuations)
    {
        var expected = 4.00;
        IAveragingStudent student = new Student(surname, name, valuations);

        var actual = student.Average;

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> NameSource()
    {
        yield return ["Тестов", "Тест", new[] { 3, 4, 5 }];
    }
}