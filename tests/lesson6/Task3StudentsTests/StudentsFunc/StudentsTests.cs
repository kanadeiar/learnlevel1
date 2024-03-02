namespace Task3StudentsTests.StudentsFunc;

public class StudentsTests
{
    [Theory, MemberData(nameof(StudentsSource))]
    public void TestStudentsData(Student[] items)
    {
        ICommonStudents students = new Students(items);

        students.Should().BeEquivalentTo(items);
    }

    [Theory, InlineAutoMoqData([new[] { "Тестов;Тест;МГУ;Мехмат;1;Математический;1;Москва;20" }])]
    public void TestCreateFromFile(string[] sourceLines, [Frozen] Mock<IFile> mock)
    {
        var expected = new Student[] { new("Тестов", "Тест", "МГУ", "Мехмат", 1, "Математический", 1, "Москва", 20) };
        mock.Setup(x => x.Exists("test.txt")).Returns(true);
        mock.Setup(x => x.ReadAllLines("test.txt")).Returns(sourceLines);
        var factory = StudentsFactoryFake.Create(mock.Object);

        ICommonStudents actual = factory.CreateFromFile("test.txt");

        mock.Verify(x => x.Exists("test.txt"), Times.Once);
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory, MemberData(nameof(StudentsSource))]
    public void TestCountOfLevels(Student[] items)
    {
        ICountingStudents students = new Students(items);

        var actual = students.CountOfLevels;

        actual.bak.Should().Be(3);
        actual.mag.Should().Be(3);
    }

    [Theory, MemberData(nameof(StudentsSource))]
    public void TestCountOfFiveSix(Student[] items)
    {
        ICountingStudents students = new Students(items);

        var actual = students.CountOfFiveSix;

        actual.five.Should().Be(1);
        actual.six.Should().Be(2);
    }

    [Theory, MemberData(nameof(StudentsSource))]
    public void TestAgesFrequency(Student[] items)
    {
        ICountingStudents students = new Students(items);
        var predicate = new Predicate<Student>(x => x.Age is >= 20 and <= 40);

        var actuals = students.CoursesFrequency(predicate);

        actuals.Keys.Count.Should().Be(2);
        actuals[5].Should().Be(1);
        actuals[6].Should().Be(2);
    }

    [Theory, MemberData(nameof(StudentsSource))]
    public void TestAgesSort(Student[] items)
    {
        ISortingStudents students = new Students(items);

        var actuals = students.AgesSort();

        actuals.Count().Should().Be(6);
        actuals.First().Age.Should().Be(18);
        actuals.Last().Age.Should().Be(34);
    }

    [Theory, MemberData(nameof(StudentsSource))]
    public void TestCourseAgeSort(Student[] items)
    {
        ISortingStudents students = new Students(items);

        var actuals = students.CoursesAgesSort();

        actuals.Count().Should().Be(6);
        actuals.First().Age.Should().Be(18);
        actuals.Last().Age.Should().Be(34);
    }

    public static IEnumerable<object[]> StudentsSource()
    {
        yield return 
        [
            new Student[]
            {
                new("Тестов3", "Тест", "МГУ", "Мехмат", 6, "Математический", 1, "Москва", 34),
                new("Тестов1", "Тест", "МГУ", "Мехмат", 1, "Математический", 1, "Москва", 18),
                new("Тестов1", "Тест", "МГУ", "Мехмат", 4, "Математический", 1, "Москва", 18),
                new("Тестов2", "Тест", "МГУ", "Мехмат", 5, "Математический", 1, "Москва", 22),
                new("Тестов3", "Тест", "МГУ", "Мехмат", 6, "Математический", 1, "Москва", 22),
                new("Тестов1", "Тест", "МГУ", "Мехмат", 1, "Математический", 1, "Москва", 18),
            }
        ];
    }
}