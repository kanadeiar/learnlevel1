using Kanadeiar.Desktop.Forms;
using Moq;

namespace Task2GuessNumberCoreTests.ComputerFunc;

public class ComputerTests
{
    [Theory, AutoMoqData]
    public void TestNotify(Mock<IFormObserver> mock)
    {
        var doubler = new Computer();
        IFormObservable observable = doubler;
        observable.AddObserver(mock.Object);

        doubler.ComputerNumber = 10;

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }

    [Theory]
    [InlineAutoMoqData(3, 3)]
    public void TestValues(int value, int expected, Computer computer)
    {
        IValueingComputer valueing = computer;
        valueing.ComputerNumber = value;
        valueing.TryingCount = value;

        valueing.ComputerNumber.Should().Be(expected);
        valueing.TryingCount.Should().Be(expected);
    }
}