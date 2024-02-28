namespace Task1FunctionsTable.FunctionsTableFunc;

public class MessagesGenerator
{
    public string GenerateTableMessage(FunctionsSource.Fun fun, double a, double x, double end)
    {
        var sb = new StringBuilder();
        sb.AppendLine("┌─────────────────────────────────┐");
        sb.AppendLine("|-------- A -------- X -------- Y |");
        for (var i = x; x <= end; x++)
        {
            sb.AppendLine($"| {a.ToString("F3", CultureInfo.InvariantCulture),8} " +
                          $"| {x.ToString("F3", CultureInfo.InvariantCulture),8} " +
                          $"| {fun(a, x).ToString("F3", CultureInfo.InvariantCulture),8}  |");
        }
        sb.AppendLine("└─────────────────────────────────┘");
        return sb.ToString();
    }
}