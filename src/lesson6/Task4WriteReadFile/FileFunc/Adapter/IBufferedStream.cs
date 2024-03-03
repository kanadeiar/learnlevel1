namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IBufferedStream : IDisposable
{
    void Write(byte[] buffer);
    int Read(byte[] buffer, int offset, int count);
}

public class BufferedStreamAdapter(FileStream stream, int bufferSize) : IBufferedStream
{
    private BufferedStream _stream = new(stream, bufferSize);

    public void Write(byte[] buffer)
    {
        _stream.Write(buffer);
    }

    public int Read(byte[] buffer, int offset, int count)
    {
        return _stream.Read(buffer, offset, count);
    }

    public void Dispose() => _stream.Dispose();
}


