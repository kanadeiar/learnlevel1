using Task4WriteReadFile.FileFunc.CharStreams;

namespace Task4WriteReadFile.FileFunc;

public class WriterReaderFactory
{
    public static IByteingWriterReader Create(MethodCode code, string filename)
    {
        return code switch
        {
            MethodCode.Stream => new StreamWriterReader(filename),
            MethodCode.Binary => new BinaryWriterReader(filename),
            MethodCode.CharStreams => new CharStreamsWriterReader(filename),
            MethodCode.Buffered => new BufferedWriterReader(filename),
            _ => throw new IndexOutOfRangeException(nameof(code))
        };
    }
}

public enum MethodCode
{
    Stream,
    Binary,
    CharStreams,
    Buffered,
}