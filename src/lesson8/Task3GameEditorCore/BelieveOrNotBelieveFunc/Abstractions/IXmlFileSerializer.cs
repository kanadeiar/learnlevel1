namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Abstractions;

public interface IXmlFileSerializer<T>
{
    void SerializeAndSave(T @object, string fileName);
    T OpenAndDeserialize(string fileName);
}