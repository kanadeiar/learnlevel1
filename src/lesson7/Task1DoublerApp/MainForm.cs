namespace Task1DoublerApp;

public partial class MainForm : Form, IFormObserver
{
    private ICommonDoubler _doubler;

    public MainForm()
    {
        InitializeComponent();

        _doubler = new Doubler();
        _doubler.AddObserver(this);
        _doubler.OnStarted += gameingOnStarted;
        _doubler.OnWon += gameingOnOnWon;
        
        Update(_doubler, null);
        setEnabledForButtons(false);
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

    private void gameingOnStarted(object? sender, StartedEventArgs e)
    {
        setEnabledForButtons(true);
        MessageBox.Show($"����� �������� ����� {_doubler.WinNumber}", "���� ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void gameingOnOnWon(object? sender, WonEventArgs e)
    {
        setEnabledForButtons(false);
        MessageBox.Show($"�� �������� � ���� ���� �� {_doubler.Count} ������!", "������������", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void setEnabledForButtons(bool isEnabled)
    {
        buttonPlus.Enabled = buttonDouble.Enabled = buttonReset.Enabled = buttonUndo.Enabled = isEnabled;
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

    private void buttonUndo_Click(object sender, EventArgs e)
    {
        _doubler.Undo();
    }
}




