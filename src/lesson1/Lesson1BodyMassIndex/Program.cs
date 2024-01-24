using Kanadeiar.Common;
using Lesson1BodyMassIndex.BodyMassIndexModule;

ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Написать программу расчета индекса массы тела.");

var calculator = Calculator.Create();

calculator.Weight = ConsoleHelper.ReadNumberFromConsole<double>("Введите вес в килограммах");
calculator.Height = ConsoleHelper.ReadNumberFromConsole<double>("Введите рост в метрах");

Console.WriteLine(calculator.Print());

ConsoleHelper.PrintFooter();
