using Kanadeiar.Common.Console;

namespace Task3StringComparison;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 3", "Задача № 3. Сравнение двух строк с перестановкой.");

        var first = ConsoleHelper.ReadLineFromConsole("Введите первое слово");
        var second = ConsoleHelper.ReadLineFromConsole("Введите второе слово");

        comparisonDialog(first, second);

        ConsoleHelper.PrintFooter();
    }

    private static void comparisonDialog(string? first, string? second)
    {
        if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
        {
            return;
        }

        if (Comparison.ShuffleComparison(first, second))
        {
            Console.WriteLine("Эти две строки являются строками - перестановками");
        }
        else
        {
            Console.WriteLine("Эти две строки НЕ являются строками - перестановками");
            Console.Beep();
        }
    }
}