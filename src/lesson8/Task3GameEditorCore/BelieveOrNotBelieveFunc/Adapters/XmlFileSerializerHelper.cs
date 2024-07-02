using System.Xml.Serialization;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Abstractions;

namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

public class XmlFileSerializerHelper<T> : IXmlFileSerializer<T>
{
    public void SerializeAndSave(T @object, string fileName)
    {
        using var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        var serializer = new XmlSerializer(typeof(T));
        serializer.Serialize(stream, @object);
    }

    public T OpenAndDeserialize(string fileName)
    {
        using var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        var serializer = new XmlSerializer(typeof(T));
        var @object = (T)serializer.Deserialize(stream)!;
        return @object;
    }
}