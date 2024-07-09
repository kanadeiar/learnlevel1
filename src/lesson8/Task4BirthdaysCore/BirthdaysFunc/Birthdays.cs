using System.Collections;
using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;
using Task4BirthdaysCore.BirthdaysFunc.Abstractions;
using Task4BirthdaysCore.BirthdaysFunc.Adapters;
using Task4BirthdaysCore.BirthdaysFunc.Base;

[assembly: InternalsVisibleTo("Task4BirthdaysCoreTests")]
namespace Task4BirthdaysCore.BirthdaysFunc;

public class Birthdays : ModelBase, ICommonBirthdays
{
    internal BirthdaysData data = new();

    internal IXmlFileSerializer<List<Birthday>>? serializer;

    private Birthday _selected = new ();

    public Birthday Selected
    {
        get => _selected; 
        set => Set(ref _selected, value);
    }

    public void Select(int index)
    {
        if (index < 0 || index >= data.Count()) return;

        Selected = data.ToArray()[index];
    }

    private string _fileName;
    
    public string FileName
    {
        get => _fileName;
        set => Set(ref _fileName, value);
    }

    public Birthdays(string fileName)
    {
        this._fileName = fileName;
    }

    public void Add(Birthday birthday)
    {
        data.Add(birthday);
        NotifyObservers();
    }

    public void Edit(int index, Birthday birthday)
    {
        data.Edit(index, birthday);
        NotifyObservers();
    }

    public void Remove(Birthday birthday)
    {
        data.Remove(birthday);
        NotifyObservers();
    }

    public void Save()
    {
        var ser = serializer ??= new XmlFileSerializerAdapter<List<Birthday>>();
        ser.SerializeAndSave(data.ToList(), FileName);
    }

    public void Load()
    {
        var ser = serializer ??= new XmlFileSerializerAdapter<List<Birthday>>();
        var birthdays = ser.OpenAndDeserialize(FileName);
        data = new BirthdaysData(birthdays);
        NotifyObservers();
    }

    public IEnumerator<Birthday> GetEnumerator() => data.GetEnumerator();


    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)data).GetEnumerator();
}