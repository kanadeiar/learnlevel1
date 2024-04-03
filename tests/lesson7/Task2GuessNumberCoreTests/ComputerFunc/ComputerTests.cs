using Task2GuessNumberCore.ComputerFunc.Base;
using Task2GuessNumberCoreTests.ComputerFunc.Base;

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
    public void TestStart_CheckValues(ComputerFake computer)
    {
        computer.Start();

        computer.ComputerNumber.Should().NotBe(default);
        computer.ComputerNumber.Should().BeInRange(1, 100);
        computer.TryingCount.Should().Be(Computer.TRYING_COUNT);
    }

    [Theory, AutoMoqData]
    public void TestStart_RaisedEventOnStarted(ComputerFake computer)
    {
        using var monitor = computer.Monitor();

        computer.Start();

        monitor.Should()
            .Raise(nameof(computer.OnStarted))
            .WithArgs<StartedEventArgs>(arg => arg.TryingCount == Computer.TRYING_COUNT);
    }

    [Theory, AutoMoqData]
    public void TestTryNumber_RaisedEventOnWon(ComputerFake computer)
    {
        computer.Start();
        using var monitor = computer.Monitor();

        computer.TryNumber(computer.ComputerNumber);

        monitor.Should()
            .Raise(nameof(computer.OnWon))
            .WithArgs<WonEventArgs>();
    }
}