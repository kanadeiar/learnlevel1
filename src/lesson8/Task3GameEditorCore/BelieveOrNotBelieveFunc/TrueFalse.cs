namespace Task3GameEditorCore.BelieveOrNotBelieveFunc;

public class TrueFalse
{
    private List<Question> _questions = new List<Question>();

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
        _questions.Add(new Question(text, isTrue));
    }

    public void Remove(int index)
    {
        if (index < _questions.Count && index >= 0)
        {
            _questions.RemoveAt(index);
        }
    }

    public Question this[int index] => _questions[index];

    public int Count => _questions.Count;

    public void Save()
    {
        var xmlFormat = new XmlSerializer(typeof(List<Question>));
        using var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
        xmlFormat.Serialize(stream, _questions);
        stream.Close();
    }

    public void Load()
    {
        var xmlFormat = new XmlSerializer(typeof(List<Question>));
        using var stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
        _questions = (List<Question>)xmlFormat.Deserialize(stream)!;
        stream.Close();
    }
}