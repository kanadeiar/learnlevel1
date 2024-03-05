using Task4WriteReadFile.FileFunc.Buffered;
using Task4WriteReadFile.FileFunc.Stream;

namespace Task4WriteReadFile.FileFunc;

public class WriterReaderFactory
{
    public static IByteingWriterReader StreamCreate(string filename)
    {
        return new StreamWriterReader(filename);
    }    
    
    public static INumberWriterReader BinaryCreate(string filename)
    {
        return new NumberWriterReader(filename);
    }

    public static ICharWriterReader StreamsCreate(string filename)
    {
        return new CharWriterReader(filename);
    }

    public static IByteingWriterReader BufferedCreate(string filename)
    {
        return new BufferedWriterReader(filename);
    }
}