namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IStreamReader : IDisposable
{
    int Peek();
    int Read();
}

public class StreamReaderAdapter(FileStream stream) : IStreamReader
{
    private readonly StreamReader _reader = new(stream);

    public int Peek()
    {
        return _reader.Peek();
    }

    public int Read()
    {
        return _reader.Read();
    }

    public void Dispose() => _reader.Dispose();
}