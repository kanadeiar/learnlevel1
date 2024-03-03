namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IBinaryReader : IDisposable
{
    int PeekChar();
    int Read();
}

public class BinaryReaderAdapter(FileStream stream) : IBinaryReader
{
    private BinaryReader _reader = new(stream);

    public int PeekChar()
    {
        return _reader.PeekChar();
    }

    public int Read()
    {
        return _reader.Read();
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}