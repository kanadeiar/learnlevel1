namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

public class FileStreamAdapter : IFileStream
{
    private FileStream _fileStream;

    public FileStreamAdapter(FileStream fileStream)
    {
        _fileStream = fileStream;
    }

    public void Dispose()
    {
        _fileStream.Dispose();
    }

    public Stream GetStream()
    {
        return _fileStream;
    }
}