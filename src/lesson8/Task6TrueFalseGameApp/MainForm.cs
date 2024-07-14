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
            labelQuestion.Text = manager.QuestionText;
            buttonStart.Visible = manager.EnableStart;
            buttonYes.Visible = buttonNo.Visible = manager.EnableAnswer;
        }
    }

    private void buttonStart_Click(object sender, EventArgs e) 
        => _gameManager.Start();

    private void buttonYes_Click(object sender, EventArgs e) 
        => _gameManager.Yes();

    private void buttonNo_Click(object sender, EventArgs e) 
        => _gameManager.No();
}