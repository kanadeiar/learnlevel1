using Kanadeiar.Common;

ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Написать метод, возвращающий минимальное из трёх чисел.");

var first = ConsoleHelper.ReadNumberFromConsole<int>("Введите первое число");
var second = ConsoleHelper.ReadNumberFromConsole<int>("Введите второе число");
var third = ConsoleHelper.ReadNumberFromConsole<int>("Введите третье число");

var finder = Finder.CreateInstance(first, second, third);

var minimal = finder.Min();

Console.WriteLine(Environment.NewLine + "Минимальное число: " + minimal);

ConsoleHelper.PrintFooter();