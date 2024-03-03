namespace Task4WriteReadFile.FileFunc.Buffered;

public interface IBufferedWriterReader
{
    public void Write(byte[] data);
    public byte[] Read();
}