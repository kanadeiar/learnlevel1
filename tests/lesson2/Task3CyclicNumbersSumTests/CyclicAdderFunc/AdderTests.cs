using Task3CyclicNumbersSum.CyclicAdderFunc;

namespace Task3CyclicNumbersSumTests.CyclicAdderFunc;

public class AdderTests
{
    [Fact]
    public void AddNumber()
    {
        IAddingAdder adder = Adder.CreateInstance();

        adder.AddNumber(1);
        _ = adder.AddNumber(100);

        var numbers = (adder as IDataAdder).Numbers.ToArray();
        Assert.Equal(1, numbers[0]);
        Assert.Equal(100, numbers[1]);
    }
}