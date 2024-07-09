namespace Task4BirthdaysCore.BirthdaysFunc.Abstractions;

public interface IXmlFileSerializer<T>
{
    void SerializeAndSave(T @object, string fileName);
    T OpenAndDeserialize(string fileName);
}