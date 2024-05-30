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
    string ReflectionResult { get; set; }
}