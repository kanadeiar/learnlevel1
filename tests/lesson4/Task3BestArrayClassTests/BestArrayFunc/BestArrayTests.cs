namespace Task3BestArrayClassTests.BestArrayFunc;

public class BestArrayTests
{
    [Fact]
    public void TestCtor()
    {
        var array = BestArray.Factory.Create(10);

        TestHelper.AssertValuesInArray(array);
    }

    [Theory, AutoMoqData]
    public void TestCtor_WhenFromFile([Frozen]Mock<IFile> mock, int[] numbers)
    {
        mock.Setup(x => x.Exists("test.txt")).Returns(true);
        mock.Setup(x => x.ReadAllLines("test.txt")).Returns(numbers.Select(x => x.ToString()).ToArray);
        var array = BestArray.Factory.Create("test.txt", mock.Object);

        mock.Verify(x => x.Exists("test.txt"), Times.Once);
        TestHelper.AssertValuesInArray(array, numbers);
    }

    [Theory, InlineData(3, 2, 3, new [] { 3, 5, 7 })]
    public void TestCtor_WhenStartStep(int start, int step, int size, int[] expected)
    {
        var array = BestArray.Factory.Create(start, step, size);

        TestHelper.AssertValuesInArray(array, expected);
    }

    [Fact]
    public void TestMax()
    {
        var array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Max;

        actual.Should().Be(100);
    }

    [Fact]
    public void TestSum()
    {
        var array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Sum;

        actual.Should().Be(250);
    }

    [Fact]
    public void TestInverse()
    {
        var expected = new[] { 0, -25, -50, -75, -100 };
        var array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Inverse;

        TestHelper.AssertValuesInArray(actual, expected);
    }

    [Fact]
    public void TestMultiply()
    {
        var expected = new[] { 0, 50, 100, 150, 200 };
        var array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Multiply(2);

        TestHelper.AssertValuesInArray(actual, expected);
    }

    [Fact]
    public void TestMaxCount()
    {
        var array = BestArray.Factory.Create(0, 25, 5);
        array[0] = 100;

        var actual = array.MaxCount;

        actual.Should().Be(2);
    }

    [Fact]
    public void TestToString()
    {
        var array = BestArray.Factory.Create(10);
        var expected = TestHelper.CreateExpected(array);

        var actual = array.ToString();

        actual.Should().Be(expected);
    }
}