using Kanadeiar.Desktop.Forms;
using Task6TrueFalseGameCore.GameModule;

namespace Task6TrueFalseGameApp;

public partial class MainForm : Form, IFormObserver
{
    private GameManager _gameManager;

    public MainForm()
    {
        InitializeComponent();

        _gameManager = new GameManager("gamedata.xml");
        _gameManager.AddObserver(this);
    }

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is GameManager manager)
        {
            
        }
    }
}