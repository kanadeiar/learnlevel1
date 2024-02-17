namespace Task2StaticClass;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Статический класс и чтение из файла.");

        Console.WriteLine("Массив из случайных чисел:");
        var numbers = Counter.Generate(20).ToArray();
        Array.ForEach(numbers, Console.WriteLine);
        Console.WriteLine($"Кол-во пар элементов массива, в которых только одно число делится на три: {Counter.Count(numbers)}");

        ConsoleHelper.Pause();

        Console.WriteLine("Считанные из файла данные:");
        var fromFileNumbers = Counter.LoadFromFile("data.txt").ToArray();
        Array.ForEach(fromFileNumbers, Console.WriteLine);
        Console.WriteLine($"Кол-во пар элементов массива, в которых только одно число делится на три: {Counter.Count(fromFileNumbers)}");

        ConsoleHelper.Pause();

        Console.WriteLine("Проверка ошибки при считывании из несуществующего файла:");
        try
        {
            _ = Counter.LoadFromFile(@"нет_такого_файла.txt");
        }
        catch (Exception e)
        {
            ConsoleHelper.Pause(e.Message + "\nДальнейшая работа программы невозможна. Нажмите любую кнопку ...");
            Console.Beep();
            return;
        }

        ConsoleHelper.PrintFooter();
    }
}