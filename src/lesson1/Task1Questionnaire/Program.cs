ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Написать программу «Анкета».");

var surName = ConsoleHelper.ReadLineFromConsole("Введите фамилию");
var name = ConsoleHelper.ReadLineFromConsole("Введите имя");
var age = ConsoleHelper.ReadNumberFromConsole<int>("Введите возраст"); 
var height = ConsoleHelper.ReadNumberFromConsole<int>("Введите рост");
var weight = ConsoleHelper.ReadNumberFromConsole<int>("Введите вес");

var anketa = Questionnaire.Create(name, surName, age, height, weight);

Console.WriteLine("\nСклеивание:");
Console.WriteLine(anketa.GetText(TextFormatCode.GluedLine));

Console.WriteLine("\nФорматирование:");
Console.WriteLine(anketa.GetText(TextFormatCode.Formatted));

Console.WriteLine("\nИнтерполяция:");
Console.WriteLine(anketa.GetText(TextFormatCode.Interpolated));

ConsoleHelper.PrintFooter();


