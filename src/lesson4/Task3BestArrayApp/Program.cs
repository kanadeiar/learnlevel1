namespace Task3BestArrayApp;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Статический класс и чтение из файла.");

        var start = ConsoleHelper.ReadNumberFromConsole<int>("Начальное значение (int)");
        var size = ConsoleHelper.ReadNumberFromConsole<int>("Размер массива (int)");
        var step = ConsoleHelper.ReadNumberFromConsole<int>("Шаг заполнения массива (int)");
        var array = BestArray.Factory.Create(start, step, size);
        Console.WriteLine("Сгенерированный массив:");
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Сумма элементов массива: {0}", array.Sum);
        Console.WriteLine("Инвертированный массив:");
        var inverted = array.Inverse;
        for (var i = 0; i < inverted.Length; i++)
        {
            Console.Write("{0} ", inverted[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Массив с перемноженными на 2 элементами:");
        var multiplied = array.Multiply(2);
        for (var i = 0; i < multiplied.Length; i++)
        {
            Console.Write("{0} ", multiplied[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Количество максимальных элементов: {0}", array.MaxCount);

        ConsoleHelper.Pause();

        Console.WriteLine("Частота вхождения каждого элемента в этом массиве:");
        var frenquency = array.FrequencyDictionary();
        foreach (var item in frenquency)
        {
            Console.Write($"{item.Key}-{item.Value} ");
        }

        ConsoleHelper.PrintFooter();
    }
}