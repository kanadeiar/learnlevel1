namespace Task4WriteReadFile.FileFunc.Adapter;

public interface IFileStream : IDisposable
{
    long Length { get; }
    void Write(byte[] bytes);
    int Read(byte[] bytes, int offset, int count);
}

public class FileStreamAdapter(string filename, FileMode mode, FileAccess access) : IFileStream
{
    private FileStream _stream = new FileStream(filename, mode, access);

    public long Length => _stream.Length;

    public void Write(byte[] bytes) => _stream.Write(bytes);

    public int Read(byte[] bytes, int offset, int count) => _stream.Read(bytes, offset, count);
    
    public void Dispose() => _stream.Dispose();
}