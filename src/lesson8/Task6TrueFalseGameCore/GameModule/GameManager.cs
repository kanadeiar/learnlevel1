using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;
using Task6TrueFalseGameCore.GameModule.Abstractions;
using Task6TrueFalseGameCore.GameModule.Adapters;

[assembly: InternalsVisibleTo("Task6TrueFalseGameCoreTests")]
namespace Task6TrueFalseGameCore.GameModule;

public class GameManager : ModelBase
{
    private readonly string _fileName;

    internal GameBase game;

    internal List<Question> allQuestions = new ();

    internal int[] generedQuestions = Array.Empty<int>();

    internal Question Current => allQuestions[generedQuestions[currentQuestion]];

    internal int currentQuestion = 0;

    internal int countTrueAnswers = 0;
    
    internal static IXmlFileSerializer<List<Question>>? serializer;

    public string QuestionText => game.QuestionText;

    public bool EnableStart => game.EnableStart;

    public bool EnableAnswer => game.EnableAnswer;

    public GameManager(string fileName)
    {
        _fileName = fileName;
        allQuestions = Load();

        game = new GameBase(this);
        NotifyObservers();
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

    public void Start()
    {
        game.Start();
        NotifyObservers();
    }

    public void Yes()
    {
        game.Yes();
        NotifyObservers();
    }

    public void No()
    {
        game.No();
        NotifyObservers();
    }
}