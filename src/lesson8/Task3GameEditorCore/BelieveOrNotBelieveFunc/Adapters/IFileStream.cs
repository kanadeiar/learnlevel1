namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

public interface IFileStream : IDisposable
{
    Stream GetStream();
}