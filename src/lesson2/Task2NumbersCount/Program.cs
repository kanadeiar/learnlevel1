using Task2NumbersCount.NumbersCounter;

ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Написать метод подсчета количества цифр числа.");

var numer = ConsoleHelper.ReadNumberFromConsole<int>("Введите число");

var counter = Counter.Create(numer);
var result = counter.GetCount();

Console.WriteLine("\nКоличество чисел в числе: {0}", result);

ConsoleHelper.PrintFooter();