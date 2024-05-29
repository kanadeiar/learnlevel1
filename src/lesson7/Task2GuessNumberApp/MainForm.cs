using Kanadeiar.Desktop.Forms;
using Task2GuessNumberCore.ComputerFunc;
using Task2GuessNumberCore.ComputerFunc.Base;

namespace Task2GuessNumberApp;

public partial class MainForm : Form, IFormObserver
{
    private ICommonComputer _computer;

    public MainForm()
    {
        InitializeComponent();

        _computer = new Computer();
        _computer.AddObserver(this);
        _computer.OnStarted += ComputerOnOnStarted;
        _computer.OnNotGuessed += ComputerOnOnNotGuessed;
        _computer.OnWon += ComputerOnOnWon;
        _computer.OnGameOver += ComputerOnOnGameOver;

        Update(_computer, null);
        setEnabledForButtons(false);
    }

    private void ComputerOnOnStarted(object? sender, StartedEventArgs e)
    {
        var count = e.TryingCount;
        setEnabledForButtons(true);
        textBoxNumber.Text = string.Empty;
        MessageBox.Show($"��������� ������� ����� � ��������� �� 0 �� 100. ����� ���� {count} �������.", "���� ������", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ComputerOnOnNotGuessed(object? sender, NotGuessedEventArgs e)
    {
        var text = e.Code switch
        {
            NotGuessedCode.IsGreater => $"��������� ������� ����� ������ {e.Number}",
            NotGuessedCode.IsLess => $"��������� ������� ����� ������ {e.Number}",
            _ => "����������� �����",
        };
        MessageBox.Show("�� ������� ������� �����! " + text, "������� �������� �����", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ComputerOnOnWon(object? sender, WonEventArgs e)
    {
        setEnabledForButtons(false);
        MessageBox.Show("������������! ��� ������� ������� �����.", "���� ��������", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ComputerOnOnGameOver(object? sender, GameOverEventArgs e)
    {
        setEnabledForButtons(false);
        MessageBox.Show("� ��������� ��� �� ������� ������� �����.", "���� ���������", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void setEnabledForButtons(bool isEnabled)
    {
        groupBoxTrying.Enabled = isEnabled;
    }

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is IValueingComputer valueing)
        {
            labelTryingCount.Text = valueing.TryingCount > 0 
                ? "�������� �������: " + valueing.TryingCount
                : "���� �� ������.";
        }
    }

    private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _computer.Start();
    }

    private void buttonTry_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxNumber.Text, out var number))
        {
            _computer.TryNumber(number);
            return;
        }

        MessageBox.Show("�� ������� ��������� ����� �� ���������� ����.", "������� �������� �����",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}