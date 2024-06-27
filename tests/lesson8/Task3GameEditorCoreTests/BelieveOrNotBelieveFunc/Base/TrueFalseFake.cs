using Task3GameEditorCore.BelieveOrNotBelieveFunc;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;

namespace Task3GameEditorCoreTests.BelieveOrNotBelieveFunc.Base;

public class TrueFalseFake : TrueFalse
{
    public new IEnumerable<Question> Questions => base.Questions;

    public TrueFalseFake(string fileName, IXmlSerializer? xmlSerializer = null, IFileStream? writeFileStream = null, IFileStream? readFileStream = null) : base(fileName)
    {
        XmlSerializer = xmlSerializer!;
        WriteFileStream = writeFileStream!;
        ReadFileStream = readFileStream!;
    }
}