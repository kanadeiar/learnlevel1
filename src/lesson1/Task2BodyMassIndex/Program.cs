using Kanadeiar.Common.Console;

ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Написать программу расчета индекса массы тела.");

var weight = ConsoleHelper.ReadNumberFromConsole<double>("Введите вес в килограммах");
var height = ConsoleHelper.ReadNumberFromConsole<double>("Введите рост в метрах");

var calculator = (ICommonCalculator)new Calculator(weight, height);

Console.WriteLine(calculator.Print());

ConsoleHelper.PrintFooter();
