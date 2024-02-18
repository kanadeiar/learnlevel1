using Kanadeiar.Common.Console;

ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Написать метод, возвращающий минимальное из трёх чисел.");

var first = ConsoleHelper.ReadNumberFromConsole<int>("Введите первое число");
var second = ConsoleHelper.ReadNumberFromConsole<int>("Введите второе число");
var third = ConsoleHelper.ReadNumberFromConsole<int>("Введите третье число");

int[] numbers = new[] { first, second, third };
var finder = new Finder(numbers);

var minimal = finder.Min();

Console.WriteLine(Environment.NewLine + "Минимальное число: " + minimal);

ConsoleHelper.PrintFooter();