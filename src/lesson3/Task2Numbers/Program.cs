using Kanadeiar.Common;

namespace Task2Numbers;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Сумма положительных четных чисел.");

        var adder = new Adder();
        Console.WriteLine("Вводите числа, введите 0 для завершения");
        while (true)
        {
            var value = ConsoleHelper.ReadNumberFromConsole<int>("Введите число");
            
            var isSuccess = adder.AddNumber(value);
            if (false == isSuccess)
            {
                break;
            }
        }

        var sumPlusOddNumbers = adder.SumPlusOddNumbers();
        Console.WriteLine($"Сумма введенных положительных четных чисел: {sumPlusOddNumbers}");

        ConsoleHelper.PrintFooter();
    }
}