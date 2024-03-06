namespace Task4WriteReadFile.FileFunc.Stream;

public class StreamWriterReader : WriterReaderBase, IByteingWriterReader
{
    public StreamWriterReader(string filename) : base(filename) { }

    public void Write(byte[] data)
    {
        using var stream = Stream ??= new FileStreamAdapter(Filename, FileMode.Create, FileAccess.Write);
        
        stream.Write(data);
    }

    public byte[] Read()
    {
        using var stream = Stream ??= new FileStreamAdapter(Filename, FileMode.Open, FileAccess.Read);

        var size = (int)stream.Length;
        var result = new byte[size];
        stream.Read(result, 0, size);

        return result;
    }
}