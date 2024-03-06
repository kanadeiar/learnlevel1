namespace Task4WriteReadFileTests.FileFunc.Base;

public class BinaryWriterReaderFake : BinaryWriterReader
{
    public BinaryWriterReaderFake(string filename, IFileStream stream, IBinaryWriter writer) : base(filename)
    {
        Stream = stream;
        Writer = writer;
    }

    public BinaryWriterReaderFake(string filename, IFileStream stream, IBinaryReader reader) : base(filename)
    {
        Stream = stream;
        Reader = reader;
    }
}