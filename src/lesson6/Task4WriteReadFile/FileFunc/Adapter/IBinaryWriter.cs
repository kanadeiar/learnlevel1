namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IBinaryWriter : IDisposable
{
    void Write(int value);
}

public class BinaryWriterAdapter(FileStream stream) : IBinaryWriter
{
    private BinaryWriter _writer = new(stream);

    public void Write(int value)
    {
        _writer.Write(value);
    }

    public void Dispose()
    {
        _writer.Dispose();
    }
}