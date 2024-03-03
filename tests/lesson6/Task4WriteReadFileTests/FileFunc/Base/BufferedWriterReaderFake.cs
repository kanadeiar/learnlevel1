namespace Task4WriteReadFileTests.FileFunc.Base;

public class BufferedWriterReaderFake : BufferedWriterReader
{
    public BufferedWriterReaderFake(string filename, IFileStream stream, IBufferedStream buffered) : base(filename)
    {
        Stream = stream;
        Buffered = buffered;
    }
}