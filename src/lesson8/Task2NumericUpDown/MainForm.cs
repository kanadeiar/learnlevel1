using Kanadeiar.Desktop.Forms;

namespace Task2NumericUpDown;

public partial class MainForm : Form, IFormObserver
{
    private Data _data;

    public MainForm()
    {
        InitializeComponent();

        _data = new Data();
        _data.AddObserver(this);
    }

    private void textBoxNumber_TextChanged(object sender, EventArgs e) 
        => _data.Text = textBoxNumber.Text;

    private void numericUpDownNumber_ValueChanged(object sender, EventArgs e) 
        => _data.Value = numericUpDownNumber.Value;

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is Data data)
        {
            numericUpDownNumber.Value = data.Value;
            textBoxNumber.Text = data.Text;
        }
    }
}