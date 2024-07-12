namespace Task6TrueFalseGameCore.GameModule;

/// <summary>
/// Вопрос
/// </summary>
[Serializable]
public class Question
{
    /// <summary>
    /// Утверждение
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Это утверждение - истина
    /// </summary>
    public bool IsTrue { get; set; }
}