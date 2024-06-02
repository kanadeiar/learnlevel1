namespace Task1DateTimeReflexCore.ReflectionFunc;

/// <summary>
/// Общий рефлексор
/// </summary>
public interface ICommonReflection : ITextingReflection, IFormObservable
{
}

/// <summary>
/// Рефлексор, могущий давать результат в виде текста
/// </summary>
public interface ITextingReflection
{
    /// <summary>
    /// Результат рефлексии в виде текста
    /// </summary>
    string ReflectionResult { get; set; }

    /// <summary>
    /// Произвести рефлексию и выдать результат
    /// </summary>
    void ExecuteFor(Type type);
}