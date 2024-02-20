using Kanadeiar.Common.Console;

namespace Task5TwoDimensionalArrayApp;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 5", "Задача № 5. Двухмерный массив.");

        var rowCount = 3;
        var colCount = 4;
        var array = DoubleArray.Factory.RandomCreate(colCount, rowCount);
        Console.WriteLine("Случайно сгенерированный массив:");
        Console.WriteLine(array);

        Console.WriteLine("Сумма всех элементов: {0}", array.Sum());

        var value = 500;
        Console.WriteLine("Сумма элементов больше заданного (500): {0}", array.GreaterSum(value));

        Console.WriteLine("Минимальный элемент: {0}", array.Min);
        Console.WriteLine("Максимальный элемент: {0}", array.Max);
        var (numCol, numRow) = array.GetIndexForValue(array.Max);
        Console.WriteLine("Он находится в строке {0} и колонке {1}", numRow, numCol);

        ConsoleHelper.Pause();

        Console.WriteLine("Массив на основе файла:");

        var loadedArray = DoubleArray.Factory.CreateFromFile("DoubleArrayFile.txt");

        Console.WriteLine("Сконструированный массив по файлу:");
        Console.WriteLine(loadedArray);

        Console.WriteLine("Запись массива в файл");
        loadedArray.SaveToFile("NewDoubleArrayFile.txt");
        
        ConsoleHelper.Pause();

        Console.WriteLine("Чтение несуществующего файла");

        try
        {
            _ = DoubleArray.Factory.CreateFromFile("НетТакогоФайла.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine("Исключение: " + e.Message);
        }

        ConsoleHelper.PrintFooter();
    }
}