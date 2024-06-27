using Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

namespace Task3GameEditorCore.BelieveOrNotBelieveFunc;

public class TrueFalse
{
    private QuestionsData _questions = new(null);
    protected IEnumerable<Question> Questions => _questions;

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

    public void Add(string text, bool isTrue) => _questions.AddQuestion(text, isTrue);

    public void Remove(int index) => _questions.RemoveQuestionAt(index);

    public Question this[int index] => _questions[index];

    public int Count => _questions.Count;

    public void Save()
    {
        using var stream = WriteFileStream ??= 
            new FileStreamAdapter(new FileStream(FileName, FileMode.Create, FileAccess.Write));
        XmlSerializer.Serialize(stream, _questions.ToList());
    }

    public void Load()
    {
        using var stream = ReadFileStream ??= 
            new FileStreamAdapter(new FileStream(FileName, FileMode.Open, FileAccess.Read));
        var questions = (List<Question>)XmlSerializer.Deserialize(stream)!;
        _questions = new QuestionsData(questions);
    }
}