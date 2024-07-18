namespace Task5CSVToXMLApp.ConverterModule.Abstractions;

public interface IXmlFileSerializer<in T>
{
    void SerializeAndSave(T @object, string fileName);
}