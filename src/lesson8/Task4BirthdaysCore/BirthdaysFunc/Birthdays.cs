using System.Collections;
using System.Runtime.CompilerServices;
using Task4BirthdaysCore.BirthdaysFunc.Abstractions;
using Task4BirthdaysCore.BirthdaysFunc.Adapters;
using Task4BirthdaysCore.BirthdaysFunc.Base;

[assembly: InternalsVisibleTo("Task4BirthdaysCoreTests")]
namespace Task4BirthdaysCore.BirthdaysFunc;

public class Birthdays : ICommonBirthdays
{
    internal BirthdaysData data = new();

    internal string fileName;

    internal IXmlFileSerializer<List<Birthday>>? serializer;

    public Birthdays(string fileName)
    {
        this.fileName = fileName;
    }

    public void Add(Birthday birthday) => data.Add(birthday);

    public void Remove(Birthday birthday) => data.Remove(birthday);

    public void Save()
    {
        var ser = serializer ??= new XmlFileSerializerAdapter<List<Birthday>>();
        ser.SerializeAndSave(data.ToList(), fileName);
    }

    public void Load()
    {
        var ser = serializer ??= new XmlFileSerializerAdapter<List<Birthday>>();
        var birthdays = serializer.OpenAndDeserialize(fileName);
        data = new BirthdaysData(birthdays);
    }

    public IEnumerator<Birthday> GetEnumerator() => data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)data).GetEnumerator();
}