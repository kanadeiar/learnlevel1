using Task1DateTimeReflexCore.ReflectionFunc;
using Kanadeiar.Desktop.Forms;

namespace Task1DateTimeReflexApp;

public partial class MainForm : Form, IFormObserver
{
    private Reflection _reflection;

    public MainForm()
    {
        InitializeComponent();

        _reflection = new Reflection();
        _reflection.AddObserver(this);

        _reflection.ExecuteFor(typeof(DateTime));
    }

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is ITextingReflection testing)
        {
            textBoxResult.Text = testing.ReflectionResult;
        }
    }
}