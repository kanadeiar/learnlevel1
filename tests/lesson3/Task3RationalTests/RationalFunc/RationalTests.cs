namespace Task3RationalTests.RationalFunc;

public class RationalTests
{
    [Fact]
    public void TestValues()
    {
        var rational = new Rational(2, 3);

        rational.ToString().Should().Be("2/3");
        rational.Numerator.Should().Be(2);
        rational.Denominator.Should().Be(3);
        rational.Should().Be(new Rational(2, 3));
    }

    [Fact]
    public void TestPlus()
    {
        var rational = new Rational(2, 3);

        var actual = rational + new Rational(1, 2);

        actual.Should().Be(new Rational(7, 6));
    }

    [Fact]
    public void TestMinus()
    {
        var rational = new Rational(2, 3);

        var actual = rational - new Rational(1, 2);

        actual.Should().Be(new Rational(1, 6));
    }

    [Fact]
    public void TestMultiply()
    {
        var rational = new Rational(2, 3);

        var actual = rational * new Rational(1, 2);

        actual.Should().Be(new Rational(2, 6));
    }

    [Fact]
    public void TestDivide()
    {
        var rational = new Rational(2, 3);

        var actual = rational / new Rational(1, 2);

        actual.Should().Be(new Rational(4, 3));
    }

    [Fact]
    public void TestDecimal()
    {
        var rational = new Rational(1, 4);

        var actual = rational.Decimal;

        actual.Should().Be(0.25);
    }

    [Fact]
    public void TextCtor_WhenZeroDenominator_ThenException()
    {
        Action create = () =>
        {
            var rational = new Rational(1, 0);
        };

        create.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void TestSimplify()
    {
        var rational = new Rational(3, 9);

        var actual = rational.Simplify();

        actual.Should().Be(new Rational(1, 3));
    }
}