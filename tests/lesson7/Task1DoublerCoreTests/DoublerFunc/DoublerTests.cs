namespace Task1DoublerCoreTests.DoublerFunc;

public class DoublerTests
{
    [Theory, AutoMoqData]
    public void TestNotify(Mock<IFormObserver> mock)
    {
        var doubler = new Doubler();
        IFormObservable observable = doubler;
        observable.AddObserver(mock.Object);

        doubler.Number = 99;

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }

    [Theory]
    [InlineAutoMoqData(3, 3)]
    public void TestValues(int value, int expected, Doubler doubler)
    {
        IValueingDoubler valueing = doubler;
        valueing.Number = value;
        valueing.Count = value;
        valueing.WinNumber = value;

        valueing.Number.Should().Be(expected);
        valueing.Count.Should().Be(expected);
        valueing.WinNumber.Should().Be(expected);
    }

    [Theory]
    [InlineAutoMoqData(3, 4)]
    public void TestIncrement(int value, int expected, Doubler doubler)
    {
        ICommonDoubler common = doubler;
        common.Number = value;

        doubler.Increment();

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineAutoMoqData(3, 6)]
    public void TestDouble(int value, int expected, Doubler doubler)
    {
        ICommonDoubler common = doubler;
        common.Number = value;

        doubler.Double();

        doubler.Number.Should().Be(expected);
    }

    [Theory]
    [InlineAutoMoqData(3, 0)]
    public void TestReset(int value, int expected, Doubler doubler)
    {
        IValueingDoubler valueing = doubler;
        IControllingDoubler controlling = doubler;
        valueing.Number = value;

        controlling.Reset();

        valueing.Number.Should().Be(expected);
    }

    [Theory, AutoMoqData]
    public void TestCount(Doubler doubler)
    {
        IControllingDoubler controlling = doubler;
        doubler.Number = 2;
            
        controlling.Reset();
        controlling.Increment();
        controlling.Double();
        controlling.Increment();

        doubler.Count.Should().Be(3);
    }

    [Theory, AutoMoqData]
    public void TestStart_CheckRandomNumber(Doubler doubler)
    {
        IGameingDoubler gameing = doubler;
        doubler.WinNumber = default;

        gameing.Start();

        doubler.WinNumber.Should().NotBe(default);
        doubler.WinNumber.Should().BeInRange(10, 100);
    }

    [Theory, AutoMoqData]
    public void TestStart_RaisedEventOnStarted(Doubler doubler)
    {
        IGameingDoubler gameing = doubler;
        using var monitor = gameing.Monitor();

        gameing.Start();

        monitor.Should()
            .Raise(nameof(gameing.OnStarted))
            .WithArgs<StartedEventArgs>(arg => arg.WinNumber == doubler.WinNumber);
    }

    [Theory, AutoMoqData]
    public void TestIncrement_RaisedEventOnWon(Doubler doubler)
    {
        IGameingDoubler gameing = doubler;
        IControllingDoubler controlling = doubler;
        using var monitor = gameing.Monitor();
        gameing.Start();
        doubler.WinNumber = 1;

        controlling.Increment();

        monitor.Should()
            .Raise(nameof(gameing.OnWon)).WithArgs<WonEventArgs>();
    }

    [Theory]
    [InlineAutoMoqData(2, 3)]
    public void TestUndo(int value, int expected, Doubler doubler)
    {
        IValueingDoubler valueing = doubler;
        IControllingDoubler controlling = doubler;
        IGameingDoubler gameing = doubler;
        gameing.Start();
        valueing.Number = value;
        controlling.Increment();
        controlling.Double();

        controlling.Undo();

        valueing.Number.Should().Be(expected);
        valueing.Count.Should().Be(1);
    }
}