using Task3CyclicNumbersSum.CyclicAdderFunc;

namespace Task3CyclicNumbersSumTests.CyclicAdderFunc;

public class AdderTests
{
    [Fact]
    public void TestAddNumber()
    {
        IAddingAdder adder = Adder.CreateInstance();

        adder.AddNumber(1);
        adder.AddNumber(2);
        var actual = adder.AddNumber(100);

        Assert.True(actual);
        var numbers = (adder as IDataAdder).Numbers.ToArray();
        Assert.Equal(1, numbers[0]);
        Assert.Equal(2, numbers[1]);
        Assert.Equal(100, numbers[2]);
    }

    [Fact]
    public void TestAddNumber_WhenZero()
    {
        IAddingAdder adder = Adder.CreateInstance();

        adder.AddNumber(100);
        var actual = adder.AddNumber(0);
        adder.AddNumber(200);

        Assert.False(actual);
        var numbers = (adder as IDataAdder).Numbers.ToArray();
        Assert.Equal(100, numbers[0]);
        Assert.Equal(1, numbers.Length);
    }

    [Theory]
    [MemberData(nameof(NumbersForTestSumPlusOdd))]
    public void TestSumPlusOdd(int[] numbers, int expected)
    {
        IAddingAdder adder = Adder.CreateInstance();
        foreach (var each in numbers)
        {
            adder.AddNumber(each);
        }
        
        var actual = (adder as ICalculatingAdder).SumPlusOdd();

        Assert.Equal(expected, actual);
    }

    public static TheoryData<int[], int> NumbersForTestSumPlusOdd = new TheoryData<int[], int>
    {
        { new[] { 1, 5, 6, 0 }, 6 },
        { new[] { 1, -2, 7, 0, 9 }, 8 },
        { new[] { 1, 3, 0, 9, 8 }, 4 },
    };
}