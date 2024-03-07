namespace Task1DoublerApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
        labelNumber.Text = (int.Parse(labelNumber.Text) + 1).ToString();
    }

    private void buttonMultiply_Click(object sender, EventArgs e)
    {
        labelNumber.Text = (int.Parse(labelNumber.Text) * 2).ToString();
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        labelNumber.Text = "1";
    }
}