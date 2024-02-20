using AutoFixture.Xunit2;
using Castle.Core.Internal;
using Kanadeiar.Tests;
using Moq;

namespace Task5TwoDimensionalArrayClassTests.DoubleArrayFunc;

public class DoubleArrayTests
{
    [Fact]
    public void TestCreate()
    {
        var array = DoubleArray.Factory.RandomCreate(4, 3);

        TestHelpers.AssertRandomValuesInArray(array);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestSum(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.Sum();

        actual.Should().Be(78);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestGreaterSum(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.GreaterSum(6);

        actual.Should().Be(57);
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

        actual.Should().Be(12);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestGetIndexForValue(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.GetIndexForValue(6);

        actual.Item1.Should().Be(1);
        actual.Item2.Should().Be(1);
    }

    [Theory, MemberData(nameof(ArraySource))]
    public void TestLength(int[,] numbers)
    {
        var array = new DoubleArray(numbers);

        var actual = array.Length;

        actual.Should().Be(12);
    }
    
    public static IEnumerable<object[]> ArraySource()
    {
        int[,] numbers =
        {
            { 1, 2, 3, 4 }, 
            { 5, 6, 7, 8 }, 
            { 9, 10, 11, 12 },
        };
        yield return new object[] { numbers };
    }

    [Theory]
    [InlineAutoMoqData([new[] {"3,4", "1,2,3,4", "5,6,7,8", "9,10,11,12" }])]
    public void TestLoadFromFile(string[] sourceLines, [Frozen]Mock<IFile> mock)
    {
        mock.Setup(x => x.Exists("test.txt")).Returns(true);
        mock.Setup(x => x.ReadAllLines("test.txt")).Returns(sourceLines);
        var factory = new DoubleArrayFactoryFake(mock.Object);

        DoubleArray array = factory.CreateFromFile("test.txt");

        mock.Verify(x => x.Exists("test.txt"), Times.Once);
        TestHelpers.AssertValuesInArray(array, sourceLines);
    }

    [Theory, AutoMoqData]
    public void TestLoadFromFile_WhenNotExists_ThenException([Frozen] Mock<IFile> mock)
    {
        var factory = new DoubleArrayFactoryFake(mock.Object);
        var action = new Action(() =>
        {
            _ = factory.CreateFromFile("test.txt");
        });

        action.Should().Throw<FileLoadException>();
    }

    [Theory]
    [InlineAutoMoqData([new[] { "2,3", "1,2,3", "4,5,6" }])]
    public void TestSaveToFile(string[] expected, [Frozen]Mock<IFile> mock)
    {
        mock.Setup(x => x.WriteAllLines("test.txt", It.IsAny<string[]>()));
        var array = new DoubleArrayFake(new[,] { { 1, 2, 3 }, { 4, 5, 6 } }, mock.Object);

        array.SaveToFile("test.txt");

        mock.Verify(x => x.WriteAllLines("test.txt", expected), Times.Once);
    }
}