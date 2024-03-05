namespace Task4WriteReadFile.FileFunc.Base;

public interface IByteingWriterReader
{
    void Write(byte[] data);
    byte[] Read();
}