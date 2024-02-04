using Task3CyclicNumbersSum.CyclicAdderFunc;

namespace Task3CyclicNumbersSumTests.CyclicAdderFunc;

public class AdderTests
{
    [Fact]
    public void AddNumber()
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
    public void AddNumber_WhenZero()
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

    [Fact]
    public void SumPlusOdd()
    {
        IAddingAdder adder = Adder.CreateInstance();
        adder.AddNumber(1);
        adder.AddNumber(5);
        adder.AddNumber(6);
        adder.AddNumber(0);
        adder.AddNumber(5);

        var actual = (adder as ICalculatingAdder).SumPlusOdd();

        Assert.Equal(6, actual);
    }
}