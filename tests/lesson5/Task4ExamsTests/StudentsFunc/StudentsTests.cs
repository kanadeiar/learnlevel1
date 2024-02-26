namespace Task4ExamsTests.StudentsFunc;

public class StudentsTests
{
    [Theory, MemberData(nameof(StudentsSource))]
    public void TestStudentsData(Student[] items)
    {
        ICommonStudents students = new Students(items);

        students.Should().BeEquivalentTo(items);
    }

    [Theory, InlineAutoMoqData([new[] { "Тестов Тест 3 4 5" }])]
    public void TestCreateFromFile(string[] sourceLines, [Frozen] Mock<IFile> mock)
    {
        var expected = new Student[] { new("Тестов", "Тест", [3, 4, 5]) };
        mock.Setup(x => x.Exists("test.txt")).Returns(true);
        mock.Setup(x => x.ReadAllLines("test.txt")).Returns(sourceLines);
        var factory = new StudentsFactoryFake(mock.Object);

        ICommonStudents actual = factory.CreateFromFile("test.txt");

        mock.Verify(x => x.Exists("test.txt"), Times.Once);
        actual.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> StudentsSource()
    {
        yield return
        [
            new Student[]
            {
                new("Тестов", "Тест", [3, 4, 5]),
                new("Иванов", "Иван", [2, 3, 4]),
                new("Тестов", "Тест", [5, 4, 3])
            }
        ];
    }
}