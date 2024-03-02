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

    [Theory, MemberData(nameof(StudentsSource))]
    public void TestDummers(Student[] items)
    {
        ICommonStudents students = new Students(items);

        var actuals = students.Dummers();

        actuals.Should().HaveCount(3);
        actuals.Last().ToString().Should().Be("Сидоров Сидор - 2.67");
    }

    [Theory, MemberData(nameof(StudentsSource))]
    public void TestDummers_WhenFourDummers(Student[] items)
    {
        var many = Enumerable.Range(1, 5).Select(_ => new Student("Васин", "Вася", [2, 2, 2]));
        var manyItems = many.Concat(items);
        ICommonStudents students = new Students(manyItems);

        var actuals = students.Dummers();

        actuals.Should().HaveCount(6);
        actuals.Last().ToString().Should().Be("Буянов Буян - 2.00");
    }

    public static IEnumerable<object[]> StudentsSource()
    {
        yield return
        [
            new Student[]
            {
                new("Тестов", "Тест", [3, 4, 5]),
                new("Иванов", "Иван", [2, 3, 4]),
                new("Петров", "Петр", [5, 4, 3]),
                new("Сидоров", "Сидор", [2, 3, 3]),
                new("Плохов", "Плох", [2, 2, 3]),
                new("Буянов", "Буян", [2, 2, 2]),
            }
        ];
    }
}