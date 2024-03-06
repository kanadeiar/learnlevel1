namespace Task4WriteReadFileTests.FileFunc;

public class BinaryWriterReaderTests
{
    [Theory, AutoMoqData]
    public void TestWrite([Frozen] Mock<IFileStream> mock, [Frozen]Mock<IBinaryWriter> writeMock, byte[] expected)
    {
        var actuals = Array.Empty<byte>();
        writeMock.Setup(x => x.Write(It.IsAny<byte[]>()))
            .Callback((byte[] bytes) => { actuals = bytes; });
        IByteingWriterReader writerReader = new BinaryWriterReaderFake("test.data", mock.Object, writeMock.Object);

        writerReader.Write(expected);

        actuals.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoMoqData]
    public void TestRead([Frozen] Mock<IFileStream> mock, [Frozen] Mock<IBinaryReader> readMock, byte[] expected)
    {
        mock.SetupGet(x => x.Length).Returns(expected.Length);
        readMock.Setup(x => x.Read(It.IsAny<byte[]>(), 0, expected.Length))
            .Callback((byte[] arr, int _, int _) =>
            {
                expected.CopyTo(arr, 0);
            })
            .Returns(expected.Length);
        IByteingWriterReader writerReader = new BinaryWriterReaderFake("test.data", mock.Object, readMock.Object);

        var actuals = writerReader.Read();

        actuals.Should().BeEquivalentTo(expected);
    }
}