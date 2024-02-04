using Task3CyclicNumbersSum.CyclicAdderFunc;

namespace Task3CyclicNumbersSumTests.CyclicAdderFunc;

public class AdderTests
{
    [Fact]
    public void TestAddNumber()
    {
        IAddingAdder adder = new Adder();

        adder.AddNumber(1);
        adder.AddNumber(2);
        var actual = adder.AddNumber(100);

        Assert.True(actual);
        var numbers = (adder as IDataAdder)!.Numbers.ToArray();
        Assert.Equal(1, numbers[0]);
        Assert.Equal(2, numbers[1]);
        Assert.Equal(100, numbers[2]);
    }

    [Fact]
    public void TestAddNumber_WhenZero()
    {
        IAddingAdder adder = new Adder();

        adder.AddNumber(100);
        var actual = adder.AddNumber(0);
        adder.AddNumber(200);

        Assert.False(actual);
        var numbers = (adder as IDataAdder)!.Numbers.ToArray();
        Assert.Equal(100, numbers[0]);
        Assert.Single(numbers);
    }

    [Theory]
    [MemberData(nameof(NumbersForTestSumPlusOdd))]
    public void TestSumPlusOdd(int[] numbers, int expected)
    {
        IAddingAdder adder = new Adder();
        foreach (var each in numbers)
        {
            adder.AddNumber(each);
        }
        
        var actual = (adder as ICalculatingAdder)!.SumPlusOdd();

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> NumbersForTestSumPlusOdd()
    {
        yield return new object[] { new int[] { 1, 5, 6, 0 }, 6 };
        yield return new object[] { new int[] { 1, -2, 7, 0, 9 }, 8 };
        yield return new object[] { new int[] { 1, 3, 0, 9, 8 }, 4 };
    }
}