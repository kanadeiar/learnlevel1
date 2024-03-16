namespace Task1DoublerCoreTests.DoublerFunc;

public class DoublerTests
{
    [Theory]
    [InlineData(3, 3)]
    public void TestValues(int value, int expected)
    {
        IValueingDoubler doubler = new Doubler { Number = value };

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, 4)]
    public void TestIncrement(int value, int expected)
    {
        ICommonDoubler doubler = new Doubler { Number = value };

        doubler.Increment();

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, 6)]
    public void TestDouble(int value, int expected)
    {
        ICommonDoubler doubler = new Doubler { Number = value };

        doubler.Double();

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, 0)]
    public void TestReset(int value, int expected)
    {
        ICommonDoubler doubler = new Doubler { Number = value };

        doubler.Reset();

        doubler.Number.Should().Be(expected);
    }

    [Fact]
    public void TestCount()
    {
        ICommonDoubler doubler = new Doubler { Number = 2 };

        doubler.Reset();
        doubler.Double();
        doubler.Increment();

        doubler.Count.Should().Be(3);
    }

    [Fact]
    public void TestStart_CheckRandomNumber()
    {
        IValueingDoubler doubler = new Doubler();
        IGameingDoubler game = (IGameingDoubler)doubler;
        doubler.WinNumber.Should().Be(default);

        game.Start();

        doubler.WinNumber.Should().NotBe(default);
        doubler.WinNumber.Should().BeInRange(10, 100);
    }

    [Fact]
    public void TestStart_RaisedEventOnStarted()
    {
        IValueingDoubler doubler = new Doubler();
        IGameingDoubler game= (IGameingDoubler)doubler;
        using var monitor = game.Monitor();

        game.Start();

        monitor.Should()
            .Raise(nameof(game.OnStarted))
            .WithArgs<StartedEventArgs>(arg => arg.WinNumber == doubler.WinNumber);
    }

    [Fact]
    public void TestStart_RaisedEventOnWin()
    {
        IValueingDoubler doubler = new Doubler();
        IGameingDoubler game = (IGameingDoubler)doubler;
        using var monitor = game.Monitor();
        game.Start();
        doubler.WinNumber = 1;

        ((IControllingDoubler)doubler).Increment();

        monitor.Should()
            .Raise(nameof(game.OnWin));
    }
}