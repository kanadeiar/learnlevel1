using Task1DoublerCore.DoublerFunc;

namespace Task1DoublerApp;

public partial class MainForm : Form, IFormObserver
{
    private IValueingDoubler _valueing;
    private IControlingDoubler _doubler;

    public MainForm()
    {
        InitializeComponent();

        var doubler = new Doubler();
        doubler.AddObserver(this);
        _valueing = doubler;
        Update(_valueing, null);
        _doubler = doubler;
    }

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is IValueingDoubler doubler)
        {
            labelNumber.Text = doubler.Number.ToString();
            labelCount.Text = doubler.Count.ToString();
        }
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
}




