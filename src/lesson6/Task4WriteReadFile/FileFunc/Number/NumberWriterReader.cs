namespace Task4WriteReadFile.FileFunc.Number;

public class NumberWriterReader : WriterReaderBase, INumberWriterReader
{
    protected IBinaryWriter? Writer;
    protected IBinaryReader? Reader;

    public NumberWriterReader(string filename) : base(filename) { }

    public void Write(int[] data)
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Open, FileAccess.Read) : null!;
        using var writer = Writer ??= new BinaryWriterAdapter(stream);

        foreach (var each in data)
        {
            writer.Write(each);
        }
    }

    public int[] Read()
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Create, FileAccess.Write) : null!;
        using var reader = Reader ??= new BinaryReaderAdapter(stream);

        var result = new List<int>();
        while (reader.PeekChar() > -1)
        {
            var current = reader.Read();
            result.Add(current);
        }

        return result.ToArray();
    }
}