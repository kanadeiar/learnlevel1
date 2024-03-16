namespace Task1DoublerCoreTests.DoublerFunc;

public class CommonDoublerTests
{
    [Theory]
    [InlineData(3, 3)]
    public void TestValues(int value, int expected)
    {
        var doubler = new Doubler { Number = value };

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, 4)]
    public void TestIncrement(int value, int expected)
    {
        var doubler = new Doubler { Number = value };

        doubler.Increment();

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, 6)]
    public void TestDouble(int value, int expected)
    {
        var doubler = new Doubler { Number = value };

        doubler.Double();

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, 1)]
    public void TestReset(int value, int expected)
    {
        var doubler = new Doubler { Number = value };

        doubler.Reset();

        doubler.Number.Should().Be(expected);
    }
}