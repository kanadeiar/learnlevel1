using System.Xml.Serialization;
using Task6TrueFalseGameCore.GameModule.Abstractions;

namespace Task6TrueFalseGameCore.GameModule.Adapters;

internal class XmlFileSerializerAdapter<T> : IXmlFileSerializer<T>
{
    public T OpenAndDeserialize(string fileName)
    {
        using var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        var serializer = new XmlSerializer(typeof(T));
        var @object = (T)serializer.Deserialize(stream)!;
        return @object;
    }
}