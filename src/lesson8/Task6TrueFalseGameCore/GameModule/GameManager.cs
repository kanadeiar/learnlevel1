using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;
using Task6TrueFalseGameCore.GameModule.Abstractions;
using Task6TrueFalseGameCore.GameModule.Adapters;

[assembly: InternalsVisibleTo("Task6TrueFalseGameCoreTests")]
namespace Task6TrueFalseGameCore.GameModule;

public class GameManager : ModelBase
{
    private readonly string _fileName;

    internal List<Question> allQuestions;

    internal static IXmlFileSerializer<List<Question>>? serializer;

    private string _questionMessage;

    public string QuestionMessage
    {
        get => _questionMessage;
        set => Set(ref _questionMessage, value);
    }

    public GameManager(string fileName)
    {
        _fileName = fileName;
        allQuestions = Load();
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