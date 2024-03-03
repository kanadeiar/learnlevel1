namespace Task4WriteReadFile.FileFunc.Buffered;

public class BufferedWriterReader(string filename) : WriterReaderBase(filename), IBufferedWriterReader
{
    protected IBufferedStream? Buffered;

    public void Write(byte[] data)
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Create, FileAccess.Write) : null!;
        using var buffered = Buffered ??= new BufferedStreamAdapter(stream, 2048);

        buffered.Write(data);
    }

    public byte[] Read()
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Open, FileAccess.Read) : null!;
        using var buffered = Buffered ??= new BufferedStreamAdapter(stream, 2048);

        var size = Stream is { } ? (int)Stream.Length : (int)stream.Length;
        var result = new byte[size];
        buffered.Read(result, 0, size);

        return result;
    }
}