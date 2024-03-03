namespace Task4WriteReadFileTests.FileFunc.Base;

public class CharWriterReaderFake : CharWriterReader
{
    public CharWriterReaderFake(string filename, IFileStream stream, IStreamWriter writer) : base(filename)
    {
        Stream = stream;
        Writer = writer;
    }

    public CharWriterReaderFake(string filename, IFileStream stream, IStreamReader reader) : base(filename)
    {
        Stream = stream;
        Reader = reader;
    }
}