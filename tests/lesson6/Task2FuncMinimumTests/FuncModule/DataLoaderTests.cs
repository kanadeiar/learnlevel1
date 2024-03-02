namespace Task2FuncMinimumTests.FuncModule;

public class DataLoaderTests
{
    [Theory, AutoMoqData]
    public void TestGetMinFromFile(Mock<IBinaryReader> mock)
    {
        setupBinaryReaderMock(mock);
        var loader = DataLoaderFake.Create(mock.Object);

        var actual = loader.GetMinFromFile("test.txt");

        actual.Should().Be(1.0);
    }

    [Theory, AutoMoqData]
    public void TestGetValuesAndMinFromFile(Mock<IBinaryReader> mock)
    {
        setupBinaryReaderMock(mock);
        var loader = DataLoaderFake.Create(mock.Object);

        var actuals = loader.GetValuesAndMinFromFile("test.txt", out double min);

        min.Should().Be(1.0);
        actuals.Should().HaveCount(2);
        actuals.First().Should().Be(4.0);
    }

    private static void setupBinaryReaderMock(Mock<IBinaryReader> mock)
    {
        mock.SetupSequence(x => x.ReadDouble())
            .Returns(4.0)
            .Returns(1.0);
        mock.SetupSequence(x => x.PeekChar())
            .Returns(0.0)
            .Returns(0.0)
            .Returns(-1.0);
    }
}