namespace Task4WriteReadFile.FileFunc;

public class WriterReaderFactory
{
    public IByteingWriterReader StreamCreate(string filename)
    {
        return new ByteingWriterReader(filename);
    }    
    
    public INumberWriterReader BinaryCreate(string filename)
    {
        return new NumberWriterReader(filename);
    }

    public ICharWriterReader StreamsCreate(string filename)
    {
        return new CharWriterReader(filename);
    }
}