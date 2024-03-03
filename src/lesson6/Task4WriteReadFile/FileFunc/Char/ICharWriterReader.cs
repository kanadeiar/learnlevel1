namespace Task4WriteReadFile.FileFunc.Char;

public interface ICharWriterReader
{
    void Write(char[] data);
    char[] Read();
}