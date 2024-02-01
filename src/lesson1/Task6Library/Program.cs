using Kanadeiar.Common;

Console.WriteLine("Метод вывода заголовка:");
ConsoleHelper.PrintHeader("Задача № 6", "Задача № 6. Собственная библиотека.");

Console.WriteLine("Метод ввода числа:");
var number = ConsoleHelper.ReadNumberFromConsole<int>("Введите число");
Console.WriteLine($"""Введенное число: {number}""");

Console.WriteLine("Метод вывода текста завершения приложения:");
ConsoleHelper.PrintFooter();