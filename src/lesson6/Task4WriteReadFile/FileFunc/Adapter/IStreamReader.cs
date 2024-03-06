namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IStreamReader : IDisposable
{
    int Read(char[] bytes, int offset, int count);
}

public class StreamReaderAdapter(FileStream stream) : IStreamReader
{
    private readonly StreamReader _reader = new(stream);
    
    public int Read(char[] bytes, int offset, int count)
    {
        return _reader.Read(bytes, offset, count);
    }

    public void Dispose() => _reader.Dispose();
}