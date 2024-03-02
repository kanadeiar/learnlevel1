namespace Task3Students;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 3", "Задача № 3. Коллекция студентов.");

        createFileDialog();

        ConsoleHelper.Pause();
        
        testStudents();

        ConsoleHelper.PrintFooter();
    }

    private static void createFileDialog()
    {
        Console.WriteLine("Нужно ли создавать файл с тестовыми данными?");
        
        var isNeed = ConsoleHelper.ReadLineFromConsole("Нужно (y - да)");
        if (!string.Equals(isNeed, "y", StringComparison.InvariantCultureIgnoreCase)) return;

        var generator = FileGenerator.Create();
        generator.GenerateCsvFile("test.csv");
    }

    private static void testStudents()
    {
        try
        {
            testWorkWithStudentsFromFile();
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка при тестировании класс студентов\n" + e);
        }
    }

    private static void testWorkWithStudentsFromFile()
    {
        var students = Students.Factory.CreateFromFile("test.csv");

        Console.WriteLine($"Количество студентов: {students.Count()}");

        var (five, six) = students.CountOfFiveSix;
        Console.WriteLine("Количество студентов пятых и шестых курсов: {0} и {1}", five, six);

        var (bak, mag) = students.CountOfLevels;
        Console.WriteLine("Количество бакалавров: {0} и магистров: {1}", bak, mag);

        Console.WriteLine("Список студентов:");
        foreach (var each in students)
        {
            Console.WriteLine(each.ToString());
        }

        ConsoleHelper.Pause();

        Console.WriteLine("Количество студентов по курсам в возрасте от 18 до 20 лет:");

        var dict = students.CoursesFrequency(x => x.Age is >= 18 and <= 20);
        foreach (var pair in dict)
        {
            Console.WriteLine("Курс: {0} Количество: {1}", pair.Key, pair.Value);
        }

        ConsoleHelper.Pause();

        Console.WriteLine("Отсортированный по возрасту список студентов:");
        foreach (var each in students.AgesSort())
        {
            Console.WriteLine(each.ToString());
        }

        Console.WriteLine("Отсортированный по курсу и возрасту список студентов:");
        foreach (var each in students.CoursesAgesSort())
        {
            Console.WriteLine(each.ToString());
        }

    }
}