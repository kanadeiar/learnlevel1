namespace Task5TwoDimensionalArrayClassTests.DoubleArrayFunc;

public class DoubleArrayTests
{
    [Fact]
    public void TestCreate()
    {
        var array = DoubleArray.Factory.RandomCreate(4, 3);

        TestHelpers.AssertValuesInArray(array);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestSum(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.Sum();

        actual.Should().Be(45);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestGreaterSum(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.GreaterSum(6);

        actual.Should().Be(24);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestMin(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.Min;

        actual.Should().Be(1);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestMax(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.Max;

        actual.Should().Be(9);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestGetIndexForValue(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.GetIndexForValue(6);

        actual.Item1.Should().Be(1);
        actual.Item2.Should().Be(2);
    }

    public static IEnumerable<object[]> ArraySource()
    {
        int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        yield return new object[] { numbers };
    }
}