using Kanadeiar.Common;

ConsoleHelper.PrintHeader("Задача № 5", "Задача № 5. Имя, фамилия, город проживания.");

var data = SurNameNameCity.CreateInstance("Рассахатский", "Андрей", "Кузнецк");

Console.WriteLine("Вывод в консоль:");
Console.WriteLine(data.GetText());
ConsoleHelper.Pause();

Console.Clear();
Console.WriteLine("Вывод в центр экрана:");
ConsoleHelper.PositionPrint(data.GetText(), 30, 9);
ConsoleHelper.Pause();

Console.Clear();
Console.WriteLine("Вывод с использованием собственного метода:");
Print(data.GetText(), 30, 9);
ConsoleHelper.Pause();

ConsoleHelper.PrintFooter();

static void Print(string ms, int x, int y)
{
    ConsoleHelper.PositionPrint(ms, x, y);
}