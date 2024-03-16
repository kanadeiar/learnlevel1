using Task1DoublerCore.DoublerFunc;

namespace Task1DoublerApp;

public partial class MainForm : Form, IFormObserver
{
    private ICommonDoubler _doubler;

    public MainForm()
    {
        InitializeComponent();

        _doubler = new Doubler();
        _doubler.AddObserver(this);
        Update(_doubler, null);

        _doubler.OnStarted += GameingOnStarted;
        _doubler.OnWin += GameingOnOnWin;
    }

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is IValueingDoubler doubler)
        {
            labelNumber.Text = doubler.Number.ToString();
            labelCount.Text = doubler.Count.ToString();
            labelWinNumber.Text = doubler.WinNumber.ToString();
        }
    }

    private void GameingOnStarted(object? sender, StartedEventArgs e)
    {
        MessageBox.Show($"Нужно получить число {_doubler.WinNumber}", "Игра запущена", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void GameingOnOnWin(object? sender, WinEventArgs e)
    {
        MessageBox.Show($"Вы победили в этой игре за {_doubler.Count} команд!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
        _doubler.Increment();
    }

    private void buttonDouble_Click(object sender, EventArgs e)
    {
        _doubler.Double();
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        _doubler.Reset();
    }

    private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _doubler.Start();
    }
}




