namespace Task4WriteReadFileTests.FileFunc;

public class StreamWriterReaderTests
{
    [Theory, AutoMoqData]
    public void TestWrite([Frozen] Mock<IFileStream> mock, byte[] expected)
    {
        var actuals = Array.Empty<byte>();
        mock.Setup(x => x.Write(It.IsAny<byte[]>()))
            .Callback((byte[] bytes) => { actuals = bytes; });
        IByteingWriterReader writerReader = new StreamWriterReaderFake("test.txt", mock.Object);

        writerReader.Write(expected);

        actuals.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoMoqData]
    public void TestRead([Frozen] Mock<IFileStream> mock, byte[] expected)
    {
        mock.SetupGet(x => x.Length).Returns(expected.Length);
        mock.Setup(x => x.Read(It.IsAny<byte[]>(), 0, expected.Length))
            .Callback((byte[] arr, int _, int _) =>
            {
                expected.CopyTo(arr, 0);
            })
            .Returns(expected.Length);
        IByteingWriterReader writerReader = new StreamWriterReaderFake("test.txt", mock.Object);

        var actuals = writerReader.Read();

        actuals.Should().BeEquivalentTo(expected);
    }
}