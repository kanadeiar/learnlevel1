using Kanadeiar.Common.Console;

namespace Task2StaticClassMessage;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Статический класс сообщений.");

        var message = ConsoleHelper.ReadLineFromConsole("Введите сообщение")!;

        var words = Message.GetWordsWhenMinLength(message, 5).ToArray();
        Console.WriteLine("Слова в сообщении с длинной менее 5 символов:");
        Array.ForEach(words, Console.WriteLine);

        var withoutWordsMessage = Message.MessageWithRemovedWords(message, 'а');
        Console.WriteLine("Сообщение без слов заканчивающихся на русскую букву 'а':");
        Console.WriteLine(withoutWordsMessage);

        Console.WriteLine("Самое длинное слово в сообщении:");
        Console.WriteLine(Message.LongestWord(message));

        Console.WriteLine("Сообщение из самых длинных слов:");
        Console.WriteLine(Message.LongWordsMessage(message));

        Console.WriteLine("Словарь частотного анализа слов в сообщении:");
        var dict = Message.FrequencyAnalysisDictionary(message);
        var text = string.Join("\n", dict.Select(pair => $"{pair.Key} => {pair.Value}"));
        Console.WriteLine(text);

        ConsoleHelper.PrintFooter();
    }
}