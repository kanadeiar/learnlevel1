namespace Task1DateTimeReflexCore.ReflectionFunc;

public class Reflection : ModelBase, ICommonReflection
{
    private string _reflectionResult = string.Empty;
    public string ReflectionResult
    {
        get => _reflectionResult;
        set => Set(ref _reflectionResult, value);
    }
}