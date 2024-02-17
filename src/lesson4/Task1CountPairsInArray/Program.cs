namespace Task1CountPairsInArray;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 1", "Задача № 1. Подсчет пар хороших чисел.");

        Console.WriteLine("Весь сгенерированный массив:");
        var generator = new Generator();
        var numbers = generator.Generate(20).ToArray();
        foreach (var each in numbers)
        {
            Console.WriteLine(each);
        }

        Console.WriteLine("Количество пар чисел, только одно из которых делиться на 3:");
        var counter = new Counter();
        var count = counter.Count(numbers);
        Console.WriteLine(count);

        ConsoleHelper.PrintFooter();
    }
}