namespace Task6TrueFalseGameCore.GameModule.Abstractions;

public interface IXmlFileSerializer<out T>
{
    T OpenAndDeserialize(string fileName);
}