namespace Task2FuncMinimum.FuncModule.Adapters;

public class BinaryWriterAdapter(FileStream stream) : IBinaryWriter
{
    private BinaryWriter _writer = new(stream);

    public void Write(double value)
    {
        _writer.Write(value);
    }

    public void Dispose()
    {
        _writer.Dispose();
    }
}