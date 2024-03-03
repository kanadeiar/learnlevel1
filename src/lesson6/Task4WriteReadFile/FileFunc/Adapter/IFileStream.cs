namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IFileStream : IDisposable
{
    long Length { get; }
    void WriteByte(byte b);
    int ReadByte();
}

public class FileStreamAdapter(string filename, FileMode mode, FileAccess access) : IFileStream
{
    private FileStream _stream = new FileStream(filename, mode, access);

    public long Length => _stream.Length;

    public void WriteByte(byte b) => _stream.WriteByte(b);

    public int ReadByte() => _stream.ReadByte();
    
    public void Dispose() => _stream.Dispose();
}