namespace Task1CheckLogin;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Проверка логина.");

        var login = ConsoleHelper.ReadLineFromConsole("Введите логин для проверки");
        
        Console.WriteLine("Простая проверка");
        var simple = Checker.Create(CheckCode.Simple);
        var simpleIsCorrect = simple.Check(login);
        Console.WriteLine(simpleIsCorrect ? "Введенный логин корректный" : "Введнный логин неправильный");

        Console.WriteLine("Проверка с регулярным выражением");
        var regex = Checker.Create(CheckCode.WithRegex);
        var regexIsCorrect = regex.Check(login);
        Console.WriteLine(regexIsCorrect ? "Введенный логин корректный" : "Введнный логин неправильный");

        ConsoleHelper.PrintFooter();
    }
}