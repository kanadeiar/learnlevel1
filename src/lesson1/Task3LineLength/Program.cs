using Kanadeiar.Common.Console;

ConsoleHelper.PrintHeader("Задача № 3", "Задача № 3. Написать программу расчета расстояния между двумя точками.");

Console.WriteLine("Начальная точка:");
var x1 = ConsoleHelper.ReadNumberFromConsole<int>("x1");
var y1 = ConsoleHelper.ReadNumberFromConsole<int>("y1");

Console.WriteLine("Конечная точка:");
var x2 = ConsoleHelper.ReadNumberFromConsole<int>("x2");
var y2 = ConsoleHelper.ReadNumberFromConsole<int>("y2");

var line = Line.Create(new Point(x1, y1), new Point(x2, y2));

var result = line.Length();
Console.WriteLine($"Вычисленная длинна: {result:F}");

Console.WriteLine($"Сформированная строка с результатом: {line.TextLength()}");

ConsoleHelper.PrintFooter();
