﻿using Kanadeiar.Common;
using Lesson1Anketa.AnketaFeat;
using Lesson1Anketa.AnketaFeat.TextFormat;

ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Написать программу «Анкета».");

var anketa = IFaсtoryAnketa.Create();

anketa.SurName = ConsoleHelper.ReadLineFromConsole("Введите фамилию");
anketa.Name = ConsoleHelper.ReadLineFromConsole("Введите имя");
anketa.Age = ConsoleHelper.ReadNumberFromConsole<int>("Введите возраст");
anketa.Height = ConsoleHelper.ReadNumberFromConsole<int>("Введите рост");
anketa.Weight = ConsoleHelper.ReadNumberFromConsole<int>("Введите вес");

Console.WriteLine("\nСклеивание:");
Console.WriteLine(anketa.GetText(TextFormatType.GluedLine));

Console.WriteLine("\nФорматирование:");
Console.WriteLine(anketa.GetText(TextFormatType.Formatted));

Console.WriteLine("\nИнтерполяция:");
Console.WriteLine(anketa.GetText(TextFormatType.Interpolated));

ConsoleHelper.PrintFooter();


