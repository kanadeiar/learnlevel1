namespace Task6TrueFalseGameCore.GameModule;

public class GameBase
{
    public const int SIZE_QUESTION = 3;

    private readonly GameManager _manager;

    private GameMode _mode;
    
    public string QuestionText
    {
        get
        {
            var text = _mode switch
            {
                GameMode.Welcome => "Добро пожаловать в игру!\nНажмите пожалуйства кнопку для начала игры!",
                GameMode.Question => _manager.Current.Text,
                GameMode.Victory => "Поздравления!\nВы выиграли игру!\nНажмите на кнопку для повторной игры.",
                GameMode.GameOver => $"Вы проиграли игру!\nВы правильно ответили только на {_manager.countTrueAnswers} вопроса из {SIZE_QUESTION}",
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

    public GameBase(GameManager manager, GameMode mode = GameMode.Welcome)
    {
        _manager = manager;
        _mode = mode;
    }

    public void Start()
    {
        _mode = GameMode.Question;
        var rnd = new Random();
        _manager.generedQuestions = new int[SIZE_QUESTION];
        var randNumbers = Enumerable.Range(0, _manager.allQuestions.Count)
            .Select(x => x)
            .ToList();
        for (var i = 0; i < SIZE_QUESTION; i++)
        {
            var r = rnd.Next(0, randNumbers.Count);
            _manager.generedQuestions[i] = randNumbers[r];
            randNumbers.RemoveAt(r);
        }

        _manager.currentQuestion = 0;
        _manager.countTrueAnswers = 0;
    }

    public void Yes()
    {
        if (_manager.Current.IsTrue)
        {
            _manager.countTrueAnswers++;
        }

        answer();
    }

    public void No()
    {
        if (_manager.Current.IsTrue == false)
        {
            _manager.countTrueAnswers++;
        }

        answer();
    }

    private void answer()
    {
        _manager.currentQuestion++;

        if (_manager.currentQuestion > SIZE_QUESTION - 1)
        {
            if (_manager.countTrueAnswers == SIZE_QUESTION)
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