using Kanadeiar.Common.Console;

ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Написать метод подсчета количества цифр числа.");

var numer = ConsoleHelper.ReadNumberFromConsole<int>("Введите число");

var counter = (ICommonCounter)new Counter(numer);
var result = counter.GetCount();

Console.WriteLine("\nКоличество чисел в числе: {0}", result);

ConsoleHelper.PrintFooter();