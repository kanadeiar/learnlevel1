﻿namespace Task3BestArrayClassTests.BestArrayFunc;

public class CommonBestArrayTests
{
    [Fact]
    public void TestCreate()
    {
        IInfoBestArray array = BestArray.Factory.RandomCreate(10);

        TestHelper.AssertRandomValuesInArray(array);
    }

    [Theory, AutoMoqData]
    public void TestCreate_WhenFromFile([Frozen]Mock<IFile> mock, int[] numbers)
    {
        mock.Setup(x => x.Exists("test.txt")).Returns(true);
        mock.Setup(x => x.ReadAllLines("test.txt")).Returns(numbers.Select(x => x.ToString()).ToArray);
        var factory = new BestArrayFactoryFake(mock.Object);

        IInfoBestArray array = factory.CreateFromFile("test.txt");

        mock.Verify(x => x.Exists("test.txt"), Times.Once);
        TestHelper.AssertValuesInArray(array, numbers);
    }

    [Theory, AutoMoqData]
    public void TestCreate_WhenNoneFile_ThenException([Frozen] Mock<IFile> mock)
    {
        var factory = new BestArrayFactoryFake(mock.Object);
        var action = new Action(() =>
        {
            _ = factory.CreateFromFile("file_not_found.txt");
        });

        action.Should().Throw<FileLoadException>();
    }

    [Theory, InlineData(3, 2, 3, new [] { 3, 5, 7 })]
    public void TestCreate_WhenStartStep(int start, int step, int size, int[] expected)
    {
        IInfoBestArray array = BestArray.Factory.Create(start, step, size);

        TestHelper.AssertValuesInArray(array, expected);
    }

    [Fact]
    public void TestMax()
    {
        IInfoBestArray array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Max;

        actual.Should().Be(100);
    }

    [Fact]
    public void TestSum()
    {
        IInfoBestArray array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Sum;

        actual.Should().Be(250);
    }

    [Fact]
    public void TestInverse()
    {
        var expected = new[] { 0, -25, -50, -75, -100 };
        IGettingBestArray array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Inverse;

        TestHelper.AssertValuesInArray(actual, expected);
    }

    [Fact]
    public void TestMultiply()
    {
        var expected = new[] { 0, 50, 100, 150, 200 };
        IGettingBestArray array = BestArray.Factory.Create(0, 25, 5);

        var actual = array.Multiply(2);

        TestHelper.AssertValuesInArray(actual, expected);
    }

    [Fact]
    public void TestMaxCount()
    {
        IInfoBestArray array = BestArray.Factory.Create(0, 25, 5);
        array[0] = 100;

        var actual = array.MaxCount;

        actual.Should().Be(2);
    }

    [Fact]
    public void TestFrequencyDictionary()
    {
        var expected = new Dictionary<int, int> { { 100, 2 }, { 25, 1 }, { 50, 1 }, { 75, 1 } };
        ICommonBestArray array = BestArray.Factory.Create(0, 25, 5);
        array[0] = 100;

        var actual = array.FrequencyDictionary();

        actual.Should().Equal(expected);
    }

    [Fact]
    public void TestToString()
    {
        IInfoBestArray array = BestArray.Factory.RandomCreate(10);
        var expected = TestHelper.CreateExpected(array);

        var actual = array.ToString();

        actual.Should().Be(expected);
    }
}