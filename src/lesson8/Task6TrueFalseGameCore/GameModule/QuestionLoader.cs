using System.Runtime.CompilerServices;
using Task6TrueFalseGameCore.GameModule.Abstractions;
using Task6TrueFalseGameCore.GameModule.Adapters;

[assembly: InternalsVisibleTo("Task6TrueFalseGameCoreTests")]
namespace Task6TrueFalseGameCore.GameModule;

internal class QuestionLoader
{
    private readonly string _fileName;

    internal static IXmlFileSerializer<List<Question>>? serializer;

    public QuestionLoader(string fileName)
    {
        _fileName = fileName;
    }

    public List<Question> Load()
    {
        try
        {
            var ser = serializer ??= new XmlFileSerializerAdapter<List<Question>>();
            return ser.OpenAndDeserialize(_fileName);
        }
        catch
        {
            return new List<Question>();
        }
    }
}