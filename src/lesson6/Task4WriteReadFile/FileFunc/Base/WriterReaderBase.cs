namespace Task4WriteReadFile.FileFunc.Base;

public abstract class WriterReaderBase
{
    private readonly string _filename;

    protected string Filename => _filename;
    
    protected IFileStream? Stream;

    public WriterReaderBase(string filename)
    {
        _filename = filename;
    }

}