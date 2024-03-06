namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IStreamWriter : IDisposable
{
    void Write(char[] buffer);
}

public class StreamWriterAdapter(FileStream stream) : IStreamWriter
{
    private readonly StreamWriter _writer = new(stream);

    public void Write(char[] buffer)
    {
        _writer.Write(buffer);
    }

    public void Dispose() => _writer.Dispose();
}