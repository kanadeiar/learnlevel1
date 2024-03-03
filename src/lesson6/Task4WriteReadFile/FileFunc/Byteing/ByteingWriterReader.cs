namespace Task4WriteReadFile.FileFunc.Byteing;

public class ByteingWriterReader : WriterReaderBase, IByteingWriterReader
{
    public ByteingWriterReader(string filename) : base(filename) { }

    public void Write(byte[] data)
    {
        using var stream = Stream ??= new FileStreamAdapter(Filename, FileMode.Open, FileAccess.Read);

        foreach (var each in data)
        {
            stream.WriteByte(each);
        }
    }

    public byte[] Read()
    {
        using var stream = Stream ??= new FileStreamAdapter(Filename, FileMode.Create, FileAccess.Write);

        var result = new byte[stream.Length];
        for (var i = 0; i < stream.Length; i++)
        {
            result[i] = (byte)stream.ReadByte();
        }

        return result;
    }
}