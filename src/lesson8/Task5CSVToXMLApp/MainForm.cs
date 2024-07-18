using Kanadeiar.Desktop.Forms;
using Task5CSVToXMLApp.ConverterModule;

namespace Task5CSVToXMLApp;

public partial class MainForm : Form, IFormObserver
{
    const string CSVFileName = "students.csv";
    const string XMLFileName = "students.xml";

    private ConverterProgram _program;

    public MainForm()
    {
        InitializeComponent();

        _program = new ConverterProgram();
        _program.AddObserver(this);
    }

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is ConverterProgram program)
        {
            listBoxData.Items.Clear();
            foreach (var each in program.Data)
            {
                listBoxData.Items.Add(each);
            }
        }
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
        try
        {
            _program.Load(CSVFileName);
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Ошибка при загрузке данных студентов из файла {CSVFileName}\n" + exception.Message);
        }
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            _program.Save(XMLFileName);
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Ошибка при сохранении данных студентов в файл {XMLFileName}\n" + exception.Message);
        }
    }
}