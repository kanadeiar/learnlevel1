using Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

namespace Task3GameEditorCore.BelieveOrNotBelieveFunc;

public class TrueFalse
{
    protected List<Question> Questions = new();

    protected IXmlSerializer XmlSerializer = new XmlSerializerAdapter(typeof(List<Question>));
    protected IFileStream? WriteFileStream;
    protected IFileStream? ReadFileStream;

    private string _fileName;

    public string FileName
    {
        get => _fileName;
        set => _fileName = value;
    }

    public TrueFalse(string fileName)
    {
        _fileName = fileName;
    }

    public void Add(string text, bool isTrue)
    {
        Questions.Add(new Question(text, isTrue));
    }

    public void Remove(int index)
    {
        if (index < Questions.Count && index >= 0)
        {
            Questions.RemoveAt(index);
        }
    }

    public Question this[int index] => Questions[index];

    public int Count => Questions.Count;

    public void Save()
    {
        using var stream = WriteFileStream ??= 
            new FileStreamAdapter(new FileStream(FileName, FileMode.Create, FileAccess.Write));
        XmlSerializer.Serialize(stream, Questions);
    }

    public void Load()
    {
        using var stream = ReadFileStream ??= 
            new FileStreamAdapter(new FileStream(FileName, FileMode.Open, FileAccess.Read));
        Questions = (List<Question>)XmlSerializer.Deserialize(stream)!;
    }
}