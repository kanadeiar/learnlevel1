using Task3GameEditorCore.BelieveOrNotBelieveFunc.Abstractions;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Base;

namespace Task3GameEditorCore.BelieveOrNotBelieveFunc;

public class TrueFalse : ITrueFalse
{
    private QuestionsData _questions = new(null);

    protected IEnumerable<Question> Questions => _questions;

    private string _fileName;

    protected string FileName
    {
        get => _fileName;
        set => _fileName = value;
    }

    private IXmlFileSerializer<List<Question>>? _questionsSerializer;
    
    protected IXmlFileSerializer<List<Question>>? QuestionsSerializer
    {
        get => _questionsSerializer;
        set => _questionsSerializer = value;
    }

    public TrueFalse(string fileName)
    {
        _fileName = fileName;
    }

    public void Add(string text, bool isTrue) => _questions.AddQuestion(text, isTrue);

    public void Remove(int index) => _questions.RemoveQuestionAt(index);

    public Question this[int index] => _questions[index];

    public int Count => Questions.Count();

    public void Save()
    {
        var serializer = _questionsSerializer ??= new XmlFileSerializerHelper<List<Question>>();
        serializer.SerializeAndSave(Questions.ToList(), FileName);
    }

    public void Load()
    {
        var serializer = _questionsSerializer ??= new XmlFileSerializerHelper<List<Question>>();
        var questions = serializer.OpenAndDeserialize(FileName);
        _questions = new QuestionsData(questions);
    }
}