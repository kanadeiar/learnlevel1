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

    [Theory, AutoMoqData]
    public void TestCount(Doubler doubler)
    {
        doubler.Number = 2;

        doubler.Reset();
        doubler.Increment();
        doubler.Double();
        doubler.Increment();

        doubler.Count.Should().Be(3);
    }

    [Theory, AutoMoqData]
    public void TestStart_CheckRandomNumber(Doubler doubler)
    {
        IGameingDoubler game = doubler;
        doubler.WinNumber = default;

        game.Start();

        doubler.WinNumber.Should().NotBe(default);
        doubler.WinNumber.Should().BeInRange(10, 100);
    }

    [Theory, AutoMoqData]
    public void TestStart_RaisedEventOnStarted(Doubler doubler)
    {
        IGameingDoubler game = doubler;
        using var monitor = game.Monitor();

        game.Start();

        monitor.Should()
            .Raise(nameof(game.OnStarted))
            .WithArgs<StartedEventArgs>(arg => arg.WinNumber == doubler.WinNumber);
    }

    [Theory, AutoMoqData]
    public void TestStart_RaisedEventOnWin(Doubler doubler)
    {
        IGameingDoubler game = doubler;
        using var monitor = game.Monitor();
        game.Start();
        doubler.WinNumber = 1;

        ((IControllingDoubler)doubler).Increment();

        monitor.Should()
            .Raise(nameof(game.OnWin));
    }

    [Theory]
    [InlineAutoMoqData(2, 3)]
    public void TestUndo(int value, int expected, Doubler doubler)
    {
        ICommonDoubler common = doubler;
        common.Start();
        common.Number = value;
        common.Increment();
        common.Double();

        common.Undo();

        common.Number.Should().Be(expected);
        common.Count.Should().Be(1);
    }
}