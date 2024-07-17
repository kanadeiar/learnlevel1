using Task6TrueFalseGameCore.GameModule.StateFunction;

namespace Task6TrueFalseGameCore.GameModule;

internal class Game
{
    public GameState GameState;

    public const int SIZE_QUESTION = 3;

    internal List<Question> allQuestions;

    internal int[] generedQuestions = Array.Empty<int>();

    internal Question Current => allQuestions[generedQuestions[currentQuestion]];

    internal int currentQuestion = 0;

    internal int countTrueAnswers = 0;
    
    public string QuestionText => GameState.QuestionText;

    public bool EnableStart => GameState.EnableStart;

    public bool EnableAnswer => GameState.EnableAnswer;

    public Game(List<Question> questions)
    {
        GameState = GameState.Default(this);
        allQuestions = questions;
    }

    public void Start() => GameState.Start();

    public void Yes() => GameState.Yes();

    public void No() => GameState.No();
}