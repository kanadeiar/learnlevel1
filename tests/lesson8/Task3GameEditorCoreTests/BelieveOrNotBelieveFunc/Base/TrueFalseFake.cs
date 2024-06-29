using Task3GameEditorCore.BelieveOrNotBelieveFunc;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Abstractions;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Base;

namespace Task3GameEditorCoreTests.BelieveOrNotBelieveFunc.Base;

public class TrueFalseFake : TrueFalse
{
    public new IEnumerable<Question> Questions => base.Questions;

    public new string FileName
    {
        get => base.FileName;
        set => base.FileName = value;
    }
    
    public TrueFalseFake(string fileName, IXmlFileSerializer<List<Question>>? serializer = null) : base(fileName)
    {
        QuestionsSerializer = serializer;
    }
}