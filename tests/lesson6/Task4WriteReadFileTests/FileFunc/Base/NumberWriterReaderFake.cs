namespace Task4WriteReadFileTests.FileFunc.Base;

public class NumberWriterReaderFake : NumberWriterReader
{
    public NumberWriterReaderFake(string filename, IFileStream stream, IBinaryWriter writer) : base(filename)
    {
        Stream = stream;
        Writer = writer;
    }

    public NumberWriterReaderFake(string filename, IFileStream stream, IBinaryReader reader) : base(filename)
    {
        Stream = stream;
        Reader = reader;
    }
}