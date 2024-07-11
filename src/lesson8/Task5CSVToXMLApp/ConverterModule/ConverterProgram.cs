using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;

[assembly: InternalsVisibleTo("Task5CSVToXMLAppTests")]
namespace Task5CSVToXMLApp.ConverterModule;

public class ConverterProgram : ModelBase
{
    internal FileConverter converter = new();

    internal Students students = new(new List<Student>());
    
    private List<string> _data = new();

    public List<string> Data
    {
        get => _data;
        set => Set(ref _data, value);
    }

    public void Load(string fileName)
    {
        students = converter.GetStudentsFromCSVFile(fileName);

        Data = students.Select(s => s.ToString()).ToList();
    }

    public void Save(string fileName)
    {
        converter.SaveStudentsToXMLFile(students.ToList(), fileName);
    }
}