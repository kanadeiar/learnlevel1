namespace Task4WriteReadFileTests.FileFunc;

public class NumberWriterReaderTests
{
    [Theory, AutoMoqData]
    public void TestWrite([Frozen] Mock<IFileStream> mock, [Frozen]Mock<IBinaryWriter> writeMock, int[] expected)
    {
        var actuals = new List<int>();
        writeMock.Setup(x => x.Write(It.IsAny<int>()))
            .Callback((int b) => { actuals.Add(b); });
        INumberWriterReader writerReader = new NumberWriterReaderFake("test.data", mock.Object, writeMock.Object);

        writerReader.Write(expected);

        actuals.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoMoqData]
    public void TestRead([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IBinaryReader> readMock, int[] expected)
    {
        readMock.SetupSequence(x => x.PeekChar())
            .Returns(0).Returns(0).Returns(0).Returns(-1);
        readMock.SetupSequence(x => x.Read())
            .Returns(expected[0]).Returns(expected[1]).Returns(expected[2]);
        INumberWriterReader writerReader = new NumberWriterReaderFake("test.data", mock.Object, readMock.Object);

        var actuals = writerReader.Read();

        actuals.Should().BeEquivalentTo(expected);
    }
}