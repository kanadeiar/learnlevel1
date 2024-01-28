ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Написать программу обмена значениями двух переменных.");

var one = ConsoleHelper.ReadNumberFromConsole<int>("Введите первое число");
var two = ConsoleHelper.ReadNumberFromConsole<int>("Введите второе число");

var swapper = Swapper.Create(one, two);

swapper.Swap(SwapType.WithBuffer);
Console.WriteLine($"Результат простого обмена: первое = {swapper.First}, второе = {swapper.Second}");
swapper.Swap(SwapType.Advanced);
Console.WriteLine($"Результат дополнительного обмена: первое = {swapper.First}, второе = {swapper.Second}");

ConsoleHelper.PrintFooter();
