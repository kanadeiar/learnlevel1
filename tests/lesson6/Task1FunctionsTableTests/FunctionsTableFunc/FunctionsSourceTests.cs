namespace Task1FunctionsTableTests.FunctionsTableFunc;

public class FunctionsSourceTests
{
    [Fact]
    public void TestMultiply()
    {
        var fun = FunctionsSource.GetFunction(FunCode.Multiply);

        var actual = fun(0, 3);

        actual.Should().Be(27);
    }

    [Fact]
    public void TestSquare()
    {
        var fun = FunctionsSource.GetFunction(FunCode.Square);

        var actual = fun(3, 4);

        actual.Should().Be(48);
    }

    [Fact]
    public void TestSin()
    {
        var fun = FunctionsSource.GetFunction(FunCode.Sin);

        var actual = fun(1, Math.PI / 2);

        actual.Should().BeApproximately(1.0, 0.1);
    }
}