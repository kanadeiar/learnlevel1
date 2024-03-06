namespace Task4WriteReadFileTests.FileFunc;

public class CharStreamsWriterReaderTests
{
    [Theory, AutoMoqData]
    public void TestWrite([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IStreamWriter> writeMock, char[] expected)
    {
        var actuals = Array.Empty<char>();
        writeMock.Setup(x => x.Write(It.IsAny<char[]>()))
            .Callback((char[] chars) => { actuals = chars; });
        IByteingWriterReader writerReader = new CharStreamsWriterReaderFake("test.data", mock.Object, writeMock.Object);

        writerReader.Write(expected.Select(x => (byte)x).ToArray());

        actuals.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoMoqData]
    public void TestRead([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IStreamReader> readMock, char[] expected)
    {
        mock.SetupGet(x => x.Length).Returns(expected.Length);
        readMock.Setup(x => x.Read(It.IsAny<char[]>(), 0, expected.Length))
            .Callback((char[] arr, int _, int _) =>
            {
                expected.CopyTo(arr, 0);
            })
            .Returns(expected.Length);
        IByteingWriterReader writerReader = new CharStreamsWriterReaderFake("test.data", mock.Object, readMock.Object);

        var actual = writerReader.Read().Select(x => (char)x).ToArray();

        actual.Should().BeEquivalentTo(expected);
    }
}