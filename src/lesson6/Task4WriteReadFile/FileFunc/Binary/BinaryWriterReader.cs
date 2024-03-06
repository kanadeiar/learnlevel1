namespace Task4WriteReadFile.FileFunc.Binary;

public class BinaryWriterReader(string filename) : WriterReaderBase(filename), IByteingWriterReader
{
    protected IBinaryWriter? Writer;
    protected IBinaryReader? Reader;

    public void Write(byte[] data)
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Create, FileAccess.Write) : null!;
        using var writer = Writer ??= new BinaryWriterAdapter(stream);

        writer.Write(data);
    }

    public byte[] Read()
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Open, FileAccess.Read) : null!;
        using var reader = Reader ??= new BinaryReaderAdapter(stream);

        var size = Stream is { } ? (int)Stream.Length : (int)stream.Length;
        var result = new byte[size];
        reader.Read(result, 0, size);

        return result.ToArray();
    }
}