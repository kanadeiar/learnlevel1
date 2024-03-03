namespace Task4WriteReadFile.FileFunc.Number;

public interface INumberWriterReader
{
    public void Write(int[] data);

    public int[] Read();
}