using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;
using Task6TrueFalseGameCore.GameModule.Abstractions;
using Task6TrueFalseGameCore.GameModule.Adapters;

[assembly: InternalsVisibleTo("Task6TrueFalseGameCoreTests")]
namespace Task6TrueFalseGameCore.GameModule;

public class GameManager : ModelBase
{
    private const int SIZE_QUESTION = 3;
    
    private readonly string _fileName;
    
    private GameMode _mode;

    internal List<Question> allQuestions = new ();

    internal int[] generedQuestions = Array.Empty<int>();

    private int _currentQuestion = 0;

    private int _countTrueAnswers = 0;
    
    internal static IXmlFileSerializer<List<Question>>? serializer;

    public string QuestionText
    {
        get
        {
            var text = _mode switch
            {
                GameMode.Welcome => "Добро пожаловать в игру!\nНажмите пожалуйства кнопку для начала игры!",
                GameMode.Question => allQuestions[generedQuestions[_currentQuestion]].Text,
                GameMode.Victory => "Поздравления!\nВы выиграли игру!\nНажмите на кнопку для повторной игры.",
                GameMode.GameOver => $"Вы проиграли игру!\nВы правильно ответили только на {_countTrueAnswers} вопроса из {SIZE_QUESTION}",
                _ => string.Empty,
            };

            return text;
        }
    }

    public bool EnableStart =>
        _mode switch
        {
            GameMode.Question => false,
            _ => true,
        };

    public bool EnableAnswer =>
        _mode switch
        {
            GameMode.Question => true,
            _ => false,
        };

    public GameManager(string fileName)
    {
        _fileName = fileName;
        allQuestions = Load();

        _mode = GameMode.Welcome;
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
        _mode = GameMode.Question;
        var rnd = new Random();
        generedQuestions = new int[SIZE_QUESTION];
        var randNumbers = Enumerable.Range(0, allQuestions.Count)
            .Select(x => x)
            .ToList();
        for (var i = 0; i < SIZE_QUESTION; i++)
        {
            var r = rnd.Next(0, randNumbers.Count);
            generedQuestions[i] = randNumbers[r];
            randNumbers.RemoveAt(r);
        }

        _currentQuestion = 0;
        _countTrueAnswers = 0;

        NotifyObservers();
    }

    public void Yes()
    {
        if (allQuestions[generedQuestions[_currentQuestion]].IsTrue)
        {
            _countTrueAnswers++;
        }

        answer();
        NotifyObservers();
    }

    public void No()
    {
        if (allQuestions[generedQuestions[_currentQuestion]].IsTrue == false)
        {
            _countTrueAnswers++;
        }

        answer();
        NotifyObservers();
    }

    private void answer()
    {
        _currentQuestion++;

        if (_currentQuestion > SIZE_QUESTION - 1)
        {
            if (_countTrueAnswers == SIZE_QUESTION)
            {
                _mode = GameMode.Victory;
            }
            else
            {
                _mode = GameMode.GameOver;
            }
        }
    }
}