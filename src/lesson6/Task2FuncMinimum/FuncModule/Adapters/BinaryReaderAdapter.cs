namespace Task2FuncMinimum.FuncModule.Adapters;

public class BinaryReaderAdapter(FileStream stream) : IBinaryReader
{
    private BinaryReader _reader = new(stream);

    public double PeekChar()
    {
        return _reader.PeekChar();
    }

    public double ReadDouble()
    {
        return _reader.ReadDouble();
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}