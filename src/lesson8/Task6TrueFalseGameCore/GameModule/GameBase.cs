namespace Task6TrueFalseGameCore.GameModule;

public class GameBase
{
    public const int SIZE_QUESTION = 3;

    internal List<Question> allQuestions;

    internal int[] generedQuestions = Array.Empty<int>();

    internal Question Current => allQuestions[generedQuestions[currentQuestion]];

    internal int currentQuestion = 0;

    internal int countTrueAnswers = 0;

    private GameMode _mode;
    
    public string QuestionText
    {
        get
        {
            var text = _mode switch
            {
                GameMode.Welcome => "Добро пожаловать в игру!\nНажмите пожалуйства кнопку для начала игры!",
                GameMode.Question => Current.Text,
                GameMode.Victory => "Поздравления!\nВы выиграли игру!\nНажмите на кнопку для повторной игры.",
                GameMode.GameOver => $"Вы проиграли игру!\nВы правильно ответили только на {countTrueAnswers} вопроса из {SIZE_QUESTION}",
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

    public GameBase(List<Question> questions)
    {
        _mode = GameMode.Welcome;
        allQuestions = questions;
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

        currentQuestion = 0;
        countTrueAnswers = 0;
    }

    public void Yes()
    {
        if (Current.IsTrue)
        {
            countTrueAnswers++;
        }

        answer();
    }

    public void No()
    {
        if (Current.IsTrue == false)
        {
            countTrueAnswers++;
        }

        answer();
    }

    private void answer()
    {
        currentQuestion++;

        if (currentQuestion > SIZE_QUESTION - 1)
        {
            if (countTrueAnswers == SIZE_QUESTION)
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