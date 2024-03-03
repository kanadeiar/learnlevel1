using Task4WriteReadFile.FileFunc.Byteing;

namespace Task4WriteReadFileTests.FileFunc.Base;

public class ByteingWriterReaderFake : ByteingWriterReader
{
    public ByteingWriterReaderFake(string filename, IFileStream stream) : base(filename)
    {
        Stream = stream;
    }
}