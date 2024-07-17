namespace Task6TrueFalseGameCore.GameModule.StateFunction;

internal abstract class GameState
{
    private Game _context;

    protected Game Context => _context;

    public abstract string QuestionText { get; }

    public virtual bool EnableStart => true;

    public virtual bool EnableAnswer => false;

    /// <summary>
    /// Первоначальное состояние - приветствие
    /// </summary>
    /// <param name="context">Контекст игры</param>
    /// <returns>Состояние - приветствие</returns>
    public static GameState Default(Game context) => new GameStateWelcome { _context = context };

    /// <summary>
    /// В состояние задания вопросов
    /// </summary>
    public void ToQuestion() => _context.GameState = new GameStateQuestion { _context = _context };

    /// <summary>
    /// В состояние победы
    /// </summary>
    public void ToVictory() => _context.GameState = new GameStateVictory { _context = _context };

    /// <summary>
    /// В состояние проигрыша
    /// </summary>
    public void ToGameOver() => _context.GameState = new GameStateGameOver { _context = _context };

    public virtual void Start()
    {
        ToQuestion();
        var rnd = new Random();
        Context.generedQuestions = new int[Game.SIZE_QUESTION];
        var randNumbers = Enumerable.Range(0, Context.allQuestions.Count)
            .Select(x => x)
            .ToList();
        for (var i = 0; i < Game.SIZE_QUESTION; i++)
        {
            var r = rnd.Next(0, randNumbers.Count);
            Context.generedQuestions[i] = randNumbers[r];
            randNumbers.RemoveAt(r);
        }

        Context.currentQuestion = 0;
        Context.countTrueAnswers = 0;
    }

    public virtual void Yes() { }

    public virtual void No() { }
}