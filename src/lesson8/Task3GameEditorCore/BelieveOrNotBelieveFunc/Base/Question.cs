namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Base;

[Serializable]
public class Question
{
    public string Text = string.Empty;

    public bool IsTrue;

    public Question() { }

    public Question(string text, bool isTrue)
    {
        Text = text;
        IsTrue = isTrue;
    }
}