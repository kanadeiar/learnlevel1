using Task4WriteReadFile.FileFunc.Byteing;

namespace Task4WriteReadFileTests.FileFunc;

public class ByteingWriterReaderTests
{
    [Theory, AutoMoqData]
    public void TestWrite([Frozen] Mock<IFileStream> mock, byte[] expected)
    {
        var actuals = new List<byte>();
        mock.Setup(x => x.WriteByte(It.IsAny<byte>()))
            .Callback((byte b) => { actuals.Add(b); });
        IByteingWriterReader writerReader = new ByteingWriterReaderFake("test.txt", mock.Object);

        writerReader.Write(expected);

        actuals.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoMoqData]
    public void TestRead([Frozen] Mock<IFileStream> mock, byte[] expected)
    {
        mock.SetupGet(x => x.Length).Returns(expected.Length);
        mock.SetupSequence(x => x.ReadByte())
            .Returns(expected[0]).Returns(expected[1]).Returns(expected[2]);
        IByteingWriterReader writerReader = new ByteingWriterReaderFake("test.txt", mock.Object);

        var actuals = writerReader.Read();

        actuals.Should().BeEquivalentTo(expected);
    }
}