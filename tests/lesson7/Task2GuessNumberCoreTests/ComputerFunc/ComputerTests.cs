namespace Task2GuessNumberCoreTests.ComputerFunc;

public class ComputerTests
{
    [Theory, AutoMoqData]
    public void TestNotify(Mock<IFormObserver> mock)
    {
        var computer = new ComputerFake();
        IFormObservable observable = computer;
        observable.AddObserver(mock.Object);

        computer.TryingCount = 11;

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }

    [Theory]
    [InlineAutoMoqData(3, 3)]
    public void TestValues(int value, int expected, ComputerFake computer)
    {
        IValueingComputer valueing = computer;
        computer.TryingCount = value;

        valueing.TryingCount.Should().Be(expected);
    }

    [Theory, AutoMoqData]
    public void TestStart_WhenCheckValues(ComputerFake computer)
    {
        computer.Start();

        computer.ComputerNumber.Should().NotBe(default);
        computer.ComputerNumber.Should().BeInRange(1, 100);
        computer.TryingCount.Should().Be(Computer.TRYING_COUNT);
    }

    [Theory, AutoMoqData]
    public void TestStart_ThenRaisedEventOnStarted(ComputerFake computer)
    {
        using var monitor = computer.Monitor();

        computer.Start();

        monitor.Should()
            .Raise(nameof(computer.OnStarted))
            .WithArgs<StartedEventArgs>(arg => arg.TryingCount == Computer.TRYING_COUNT);
    }

    [Theory, AutoMoqData]
    public void TestTryNumber_WhenGuess_ThenRaisedEventOnWon(ComputerFake computer)
    {
        computer.Start();
        using var monitor = computer.Monitor();
        var trying = computer.ComputerNumber;

        computer.TryNumber(trying);

        monitor.Should()
            .Raise(nameof(computer.OnWon))
            .WithArgs<WonEventArgs>();
    }

    [Theory]
    [InlineAutoMoqData(-1, NotGuessedCode.IsLess)]
    [InlineAutoMoqData(+1, NotGuessedCode.IsGreater)]
    public void TestTryNumber_WhenNotGuess_ThenRaisedEventOnNotGuessed(int number, NotGuessedCode code, ComputerFake computer)
    {
        computer.Start();
        using var monitor = computer.Monitor();
        var trying = computer.ComputerNumber + number;

        computer.TryNumber(trying);

        monitor.Should()
            .Raise(nameof(computer.OnNotGuessed))
            .WithArgs<NotGuessedEventArgs>(x => x.Code == code);
    }

    [Theory, AutoMoqData]
    public void TestTryNumber_When8Try_ThenRaisedEventOnGameLost(ComputerFake computer)
    {
        computer.Start();
        using var monitor = computer.Monitor();
        var trying = computer.ComputerNumber + 1;

        for (var i = 0; i < 3; i++)
        {
            computer.TryNumber(trying);
        }

        monitor.Should().Raise(nameof(computer.OnGameLost)).WithArgs<GameLostEventArgs>();
    }
}