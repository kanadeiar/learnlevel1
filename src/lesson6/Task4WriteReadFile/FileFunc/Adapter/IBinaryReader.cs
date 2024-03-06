namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IBinaryReader : IDisposable
{
    int Read(byte[] bytes, int offset, int count);
}

public class BinaryReaderAdapter(FileStream stream) : IBinaryReader
{
    private BinaryReader _reader = new(stream);
    
    public int Read(byte[] bytes, int offset, int count) => _reader.Read(bytes, offset, count);
    
    public void Dispose() => _reader.Dispose();
}