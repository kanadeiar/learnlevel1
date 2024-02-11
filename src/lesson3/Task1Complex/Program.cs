using Kanadeiar.Common;
using Task1Complex.ComplexFunc;

namespace Task1Complex;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Комплексные числа.");

        sComplexDemo();
        
        complexDemo();

        ConsoleHelper.Pause();

        while (true)
        {
            var command = ConsoleHelper.ReadLineFromConsole("Операции с комалесными числами, введите exit для завершения");
            if (command == "exit")
            {
                break;
            }

            var com1 = complex(1);
            var com2 = complex(2);
            
            Console.WriteLine("Дествие с комплексными числами");
            var action = ConsoleHelper.ReadNumberFromConsole<int>("1-сумма, 2-разность, 3-произведение, 4-частное");

            var result = doAction(action, com1, com2);
            Console.WriteLine($"Результат операции: {result}");
            Console.WriteLine();
        }

        ConsoleHelper.PrintFooter();
    }

    private static void sComplexDemo()
    {
        var c1 = new SComplex(10, 10);
        var c2 = new SComplex(2, 2);
        Console.WriteLine($"Два комплексных числа (структуры): {c1} и {c2}");
        Console.WriteLine($"Сумма чисел = {c1 + c2}");
        Console.WriteLine($"Разность чисел = {c1 - c2}");
        Console.WriteLine($"Произведение чисел = {c1 * c2}");
        Console.WriteLine($"Частное чисел = {c1 / c2}");
    }

    private static void complexDemo()
    {
        var com1 = new Complex(10, 10);
        var com2 = new Complex(2, 2);
        Console.WriteLine($"Два комплексных числа (классы): {com1} и {com2}");
        Console.WriteLine($"Сумма чисел = {com1 + com2}");
        Console.WriteLine($"Разность чисел = {com1 - com2}");
        Console.WriteLine($"Произведение чисел = {com1 * com2}");
        Console.WriteLine($"Частное чисел = {com1 / com2}");
    }

    private static Complex complex(int num)
    {
        Console.WriteLine($"Введите комплексное число № {num}");
        var re = ConsoleHelper.ReadNumberFromConsole<double>("Вещественная часть");
        var im = ConsoleHelper.ReadNumberFromConsole<double>("Мнимая часть");
        var com = new Complex(re, im);
        return com;
    }

    private static Complex doAction(int action, Complex one, Complex two)
    {
        return action switch
        {
            1 => one + two,
            2 => one - two,
            3 => one * two,
            4 => one / two,
            _ => throw new Exception("Недопустимый выбор операции с числами"),
        };
    }
}