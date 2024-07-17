using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;

[assembly: InternalsVisibleTo("Task6TrueFalseGameCoreTests")]
namespace Task6TrueFalseGameCore.GameModule;

public class GameManager : ModelBase
{
    internal static QuestionLoader? loader;

    internal GameBase game;

    public string QuestionText => game.QuestionText;

    public bool EnableStart => game.EnableStart;

    public bool EnableAnswer => game.EnableAnswer;

    public GameManager(string fileName)
    {
        loader = new QuestionLoader(fileName);
        var allQuestions = loader.Load();
        game = new GameBase(allQuestions);

        NotifyObservers();
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