using System.Xml.Serialization;

namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

public class XmlSerializerAdapter : IXmlSerializer
{
    private XmlSerializer _serializer;

    public XmlSerializerAdapter(Type type)
    {
        _serializer = new XmlSerializer(type);
    }

    public void Serialize(IFileStream stream, object? @object)
    {
        _serializer.Serialize(stream.GetStream(), @object);
    }

    public object? Deserialize(IFileStream stream)
    {
        return _serializer.Deserialize(stream.GetStream());
    }
}