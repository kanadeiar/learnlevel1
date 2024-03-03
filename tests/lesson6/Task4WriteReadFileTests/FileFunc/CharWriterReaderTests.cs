namespace Task4WriteReadFileTests.FileFunc;

public class CharWriterReaderTests
{
    [Theory, AutoMoqData]
    public void TestWrite([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IStreamWriter> writeMock, char[] expected)
    {
        var actuals = new List<char>();
        writeMock.Setup(x => x.Write(It.IsAny<char>()))
            .Callback((char b) => { actuals.Add(b); });
        ICharWriterReader writerReader = new CharWriterReaderFake("test.data", mock.Object, writeMock.Object);

        writerReader.Write(expected);

        actuals.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoMoqData]
    public void TestRead([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IStreamReader> readMock, char[] expected)
    {
        readMock.SetupSequence(x => x.Peek())
            .Returns(0).Returns(0).Returns(0).Returns(-1);
        readMock.SetupSequence(x => x.Read())
            .Returns(expected[0]).Returns(expected[1]).Returns(expected[2]);
        ICharWriterReader writerReader = new CharWriterReaderFake("test.data", mock.Object, readMock.Object);

        var actuals = writerReader.Read();

        actuals.Should().BeEquivalentTo(expected);
    }
}