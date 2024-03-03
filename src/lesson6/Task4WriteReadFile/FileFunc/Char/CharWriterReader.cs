namespace Task4WriteReadFile.FileFunc.Char;

public class CharWriterReader : WriterReaderBase, ICharWriterReader
{
    protected IStreamWriter? Writer;
    protected IStreamReader? Reader;

    public CharWriterReader(string filename) : base(filename) { }

    public void Write(char[] data)
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Create, FileAccess.Write) : null!;
        using var writer = Writer ??= new StreamWriterAdapter(stream);

        foreach (var each in data)
        {
            writer.Write(each);
        }
    }

    public char[] Read()
    {
        using var stream = Stream is null ? new FileStream(Filename, FileMode.Open, FileAccess.Read) : null!;
        using var reader = Reader ??= new StreamReaderAdapter(stream);

        var result = new List<char>();
        while (reader.Peek() > -1)
        {
            var current = reader.Read();
            result.Add((char)current);
        }

        return result.ToArray();
    }
}