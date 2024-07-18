using System.Xml.Serialization;
using Task5CSVToXMLApp.ConverterModule.Abstractions;

namespace Task5CSVToXMLApp.ConverterModule.Adapters;

internal class XmlFileSerializerAdapter<T> : IXmlFileSerializer<T>
{
    public void SerializeAndSave(T @object, string fileName)
    {
        using var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        var serializer = new XmlSerializer(typeof(T));
        serializer.Serialize(stream, @object);
    }
}