using Kanadeiar.Common.Console;

namespace Task4Exams;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 4", "Задача № 4. Задача ЕГЭ.");

        var answer = ConsoleHelper.ReadLineFromConsole("Сгенерировать новый файл с данными о студентах data.txt (y)?");
        if (string.Equals(answer, "y", StringComparison.InvariantCultureIgnoreCase))
        {
            var fileGenerator = new FileGenerator();
            fileGenerator.GenerateDataFile("data.txt");
        }

        Console.WriteLine("Получение данных студентов из файла data.txt");

        var students = Students.Factory.CreateFromFile("data.txt");
        Console.WriteLine("Все ученики со средними оценками:");
        foreach (var each in students)
        {
            Console.WriteLine(each);
        }
        ConsoleHelper.Pause();

        Console.WriteLine("Самые плохие ученики:");
        foreach (var each in students.Dummers())
        {
            Console.WriteLine(each);
        }

        ConsoleHelper.PrintFooter();
    }
}