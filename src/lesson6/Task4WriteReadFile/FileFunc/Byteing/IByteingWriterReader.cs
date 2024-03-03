namespace Task4WriteReadFile.FileFunc.Byteing;

public interface IByteingWriterReader
{
    void Write(byte[] data);

    byte[] Read();
}