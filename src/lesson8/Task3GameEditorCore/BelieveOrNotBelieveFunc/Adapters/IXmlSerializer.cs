namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

public interface IXmlSerializer
{
    void Serialize(IFileStream stream, object? @object);
    object? Deserialize(IFileStream stream);
}