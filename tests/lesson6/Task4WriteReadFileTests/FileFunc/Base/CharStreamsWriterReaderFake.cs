namespace Task4WriteReadFileTests.FileFunc.Base;

public class CharStreamsWriterReaderFake : CharStreamsWriterReader
{
    public CharStreamsWriterReaderFake(string filename, IFileStream stream, IStreamWriter writer) : base(filename)
    {
        Stream = stream;
        Writer = writer;
    }

    public CharStreamsWriterReaderFake(string filename, IFileStream stream, IStreamReader reader) : base(filename)
    {
        Stream = stream;
        Reader = reader;
    }
}