namespace Task2StaticClassTests.StaticCounterFunc;

public class CounterTests
{
    [Fact]
    public void TestGenerate()
    {
        var actuals = Counter.Generate(10);

        actuals.Should().HaveCount(10);
        foreach (var each in actuals)
        {
            each.Should().BeInRange(-10_000, 10_000);
        }
    }

    [Theory, MemberData(nameof(NumbersSource))]
    public void TestCount(int[] numbers, int expected)
    {
        var actual = Counter.Count(numbers);

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> NumbersSource()
    {
        yield return new object[] { new[] { 9, -3, 6, 9 }, 0 };
        yield return new object[] { new[] { 6, 2, 9, -3, 6 }, 2 };
        yield return new object[] { new[] { 1, 3, 9, -3, 1, 9 }, 3 };
    }

    [Theory, AutoMoqData]
    public void TestSaveToFile([Frozen]Mock<IArraySaveFile> mock)
    {
        var expected = new[] { 1, 2, 3 };
        
        Counter.SaveToFile(expected, "test.txt", mock.Object);

        mock.Verify(x => x.SaveArrayToFile(expected, "test.txt"), Times.Once);
    }

    [Theory, AutoMoqData]
    public void TestLoadFromFile([Frozen]Mock<IArrayLoadFile> mock)
    {
        var expected = new[] { 1, 2, 3 };
        mock.Setup(x => x.LoadArrayFromFile("test.txt")).Returns(expected);
        
        var actuals = Counter.LoadFromFile("test.txt", mock.Object);

        actuals.Should().HaveCount(3);
        mock.Verify(x => x.LoadArrayFromFile("test.txt"), Times.Once);
    }

    [Fact]
    public void TestLoadFromFile_WhenNotFound_ThenException()
    {
        var action = new Action(() =>
        {
            var _ = Counter.LoadFromFile("filenotfound.txt");
        });

        action.Should().Throw<FileNotFoundException>();
    }
}


