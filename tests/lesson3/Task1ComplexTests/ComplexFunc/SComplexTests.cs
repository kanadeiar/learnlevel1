namespace Task1ComplexTests.ComplexFunc;

public class SComplexTests
{
    [Theory]
    [InlineData(3, 4, "3+4i")]
    [InlineData(5, 6, "5+6i")]
    public void TestValue(double re, double im, string expected)
    {
        var complex = new SComplex(re, im);

        var actual = complex.ToString();

        complex.Re.Should().Be(re);
        complex.Im.Should().Be(im);
        actual.Should().Be(expected);
    }

    [Fact]
    public void TestPlus()
    {
        var complex = new SComplex(3, 4);

        var actual = complex + new SComplex(5, 6);

        actual.Should().Be(new SComplex(8, 10));
    }

    [Fact]
    public void TestMinus()
    {
        var complex = new SComplex(6, 5);

        var actual = complex - new SComplex(4, 3);

        actual.Should().Be(new SComplex(2, 2));
    }

    [Fact]
    public void TestMultiply()
    {
        var complex = new SComplex(3, 2);

        var actual = complex * new SComplex(4, 3);

        actual.Should().Be(new SComplex(6, 17));
    }

    [Fact]
    public void TestDivide()
    {
        var complex = new SComplex(6, 8);

        var actual = complex / new SComplex(2, 2);

        actual.Should().Be(new SComplex(3.5, 0.5));
    }
}