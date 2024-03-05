namespace Task4WriteReadFileTests.FileFunc.Base;

public class StreamWriterReaderFake : StreamWriterReader
{
    public StreamWriterReaderFake(string filename, IFileStream stream) : base(filename)
    {
        Stream = stream;
    }
}