namespace Task4WriteReadFileTests.FileFunc;

public class BufferedWriterReaderTests
{
    [Theory, AutoMoqData]
    public void TestWrite([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IBufferedStream> buffered, byte[] expected)
    {
        var actuals = Array.Empty<byte>();
        buffered.Setup(x => x.Write(It.IsAny<byte[]>()))
            .Callback((byte[] bytes) => { actuals = bytes; });
        IByteingWriterReader writerReader = new BufferedWriterReaderFake("test.data", mock.Object, buffered.Object);

        writerReader.Write(expected);

        actuals.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoMoqData]
    public void TestRead([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IBufferedStream> buffered, byte[] expected)
    {
        mock.SetupGet(x => x.Length).Returns(expected.LongLength);
        buffered.Setup(x => x.Read(It.IsAny<byte[]>(), 0, expected.Length))
            .Callback((byte[] arr, int _, int _) =>
            {
                expected.CopyTo(arr, 0);
            })
            .Returns(expected.Length);
        IByteingWriterReader writerReader = new BufferedWriterReaderFake("test.data", mock.Object, buffered.Object);

        var actuals = writerReader.Read();

        actuals.Should().BeEquivalentTo(expected);
    }
}