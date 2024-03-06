namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IBinaryWriter : IDisposable
{
    void Write(byte[] buffer);
}

public class BinaryWriterAdapter(FileStream stream) : IBinaryWriter
{
    private BinaryWriter _writer = new(stream);

    public void Write(byte[] buffer)
    {
        _writer.Write(buffer);
    }

    public void Dispose()
    {
        _writer.Dispose();
    }
}