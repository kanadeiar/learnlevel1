using Kanadeiar.Common.Console;

ConsoleHelper.PrintHeader("Задача № 3", "Задача № 3. Подсчет суммы нечетных положительных чисел.");

var adder = new Adder();
while (true)
{
    var value = ConsoleHelper.ReadNumberFromConsole<int>("Вводите числа, введите 0 для завершения");

    var isContinue = adder.AddNumber(value);
    if (isContinue == false)
    {
        break;
    }
}

Console.WriteLine("\nРезультат суммирования положительных четных введенных ранее чисел: {0}", adder.SumPlusOdd());

ConsoleHelper.PrintFooter();



