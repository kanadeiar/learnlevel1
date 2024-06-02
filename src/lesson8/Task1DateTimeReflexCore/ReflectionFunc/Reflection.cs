using System.Text;

namespace Task1DateTimeReflexCore.ReflectionFunc;

public class Reflection : ModelBase, ICommonReflection
{
    private string _reflectionResult = string.Empty;
    public string ReflectionResult
    {
        get => _reflectionResult;
        set => Set(ref _reflectionResult, value);
    }

    public void ExecuteFor(Type type)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Рефлексия типа {type.ToString()}");
        builder.AppendLine();

        builder.AppendLine("Открытые поля:");
        foreach (var item in type.GetFields())
        {
            builder.AppendLine(item.ToString());
        }
        builder.AppendLine();

        builder.AppendLine("Открытые свойства:");
        foreach (var item in type.GetProperties())
        {
            builder.AppendLine(item.ToString());
        }
        builder.AppendLine();

        builder.AppendLine("Открытые методы:");
        foreach (var item in type.GetMethods())
        {
            builder.AppendLine(item.ToString());
        }
        builder.AppendLine();

        builder.AppendLine("Все открытые члены:");
        foreach (var item in type.GetMembers())
        {
            builder.AppendLine(item.ToString());
        }

        ReflectionResult = builder.ToString();
    }
}