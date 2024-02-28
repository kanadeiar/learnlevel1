using Task1FunctionsTable.FunctionsTableFunc;

namespace Task1FunctionsTable;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Таблица функции.");

        var generator = new MessagesGenerator();
        Console.WriteLine("Таблица функции возведения в куб числа (y = x * x * x):");
        {
            var multiply = FunctionsSource.GetFunction(FunCode.Multiply);
            var message = generator.GenerateTableMessage(multiply, 0, -5, 5);
            Console.WriteLine(message);
        }
        Console.WriteLine("Таблица функции возведения в квадрат числа с прибавкой (y = a * x ^ 2):");
        {
            var square = FunctionsSource.GetFunction(FunCode.Square);
            var message = generator.GenerateTableMessage(square, 2, -5, 5);
            Console.WriteLine(message);
        }
        Console.WriteLine("Таблица функции синуса с прибавкой (y = a * sin(x)):");
        {
            var sin = FunctionsSource.GetFunction(FunCode.Sin);
            var message = generator.GenerateTableMessage(sin, 3, -5, 5);
            Console.WriteLine(message);
        }

        ConsoleHelper.PrintFooter();
    }
}