namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IStreamWriter : IDisposable
{
    void Write(char value);
}

public class StreamWriterAdapter(FileStream stream) : IStreamWriter
{
    private readonly StreamWriter _writer = new(stream);

    public void Write(char value)
    {
        _writer.Write(value);
    }

    public void Dispose() => _writer.Dispose();
}