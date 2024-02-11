namespace Task1ComplexTests.ComplexFunc;

public class ComplexTests
{
    [Theory]
    [InlineData(3, 4, "3+4i")]
    [InlineData(5, 6, "5+6i")]
    public void TestValue(double re, double im, string expected)
    {
        var complex = new Complex(re, im);

        var actual = complex.ToString();

        complex.Re.Should().Be(re);
        complex.Im.Should().Be(im);
        actual.Should().Be(expected);
    }

    [Fact]
    public void TestPlus()
    {
        var complex = new Complex(5, 4);

        var actual = complex + new Complex(7, 6);

        actual.Should().Be(new Complex(12, 10));
    }

    [Fact]
    public void TestMinus()
    {
        var complex = new Complex(6, 5);

        var actual = complex - new Complex(4, 3);

        actual.Should().Be(new Complex(2, 2));
    }

    [Fact]
    public void TestMultiply()
    {
        var complex = new Complex(3, 2);

        var actual = complex * new Complex(4, 3);

        actual.Should().Be(new Complex(6, 17));
    }

    [Fact]
    public void TestDivide()
    {
        var complex = new Complex(6, 8);

        var actual = complex / new Complex(2, 2);

        actual.Should().Be(new Complex(3.5, 0.5));
    }
}