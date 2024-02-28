namespace Task2FuncMinimum;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Нахождение минимума функции.");
            
        Console.WriteLine("Тест записи значений функции в файл test.txt");

        var func = FuncSource.GetFunc(FuncCode.Multiply);
        var saver = new DataSaver();
        saver.SaveDataFromFunc(func, "text.txt", 0, 10, 1);

        Console.WriteLine("Минимальное число на основе данных из файла:");
        {
            var loader = new DataLoader();
            var min = loader.GetMinFromFile("text.txt");
            Console.WriteLine(min.ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.WriteLine("Последние записанные данные в файл:");
        {
            var loader = new DataLoader();
            var values = loader.GetValuesAndMinFromFile("text.txt", out var min);
            foreach (var each in values)
            {
                Console.WriteLine(each);
            }

            Console.WriteLine("Минимум функции равен: {0}", min);
        }

        ConsoleHelper.PrintFooter();
    }
}