namespace Task4WriteReadFile.FileFunc.CharStreams;

public class CharStreamsWriterReader : WriterReaderBase, IByteingWriterReader
{
    protected IStreamWriter? Writer;
    protected IStreamReader? Reader;

    public CharStreamsWriterReader(string filename) : base(filename) { }

    public void Write(byte[] data)
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Create, FileAccess.Write) : null!;
        using var writer = Writer ??= new StreamWriterAdapter(stream);

        var chars = data.Select(x => (char)x).ToArray();
        
        writer.Write(chars);
    }

    public byte[] Read()
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Open, FileAccess.Read) : null!;
        using var reader = Reader ??= new StreamReaderAdapter(stream);

        var size = Stream is { } ? (int)Stream.Length : (int)stream.Length;
        var chars = new char[size];
        reader.Read(chars, 0, size);

        var result = chars.Select(x => (byte)x).ToArray();

        return result;
    }
}