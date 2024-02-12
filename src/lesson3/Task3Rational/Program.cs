using Kanadeiar.Common;

namespace Task3Rational;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 3", "Задача № 3. Класс дробей.");

        Console.WriteLine("Операции над дробями:");
        var one = new Rational(1, 2);
        var two = new Rational(1, 3);
        Console.WriteLine($"Первое число = {one} и второе число = {two}");
        Console.WriteLine($"Результат суммирования чисел = {one + two}");
        Console.WriteLine($"Результат разности чисел = {one - two}");
        Console.WriteLine($"Результат произведения чисел = {one * two}");
        Console.WriteLine($"Результат частности чисел = {one / two}");

        Console.WriteLine("Дополнительный доступ к числителю и знаменателю через свойства.");

        Console.WriteLine($"Число = {one}");
        Console.WriteLine($"Его числитель = {one.Numerator} и его знаменатель = {one.Denominator}");

        Console.WriteLine("Свойство только для чтения, чтобы получить десятичную дробь числа.");

        Console.WriteLine($"Число = {one}");
        Console.WriteLine($"Десятичная дробь этого числа = {one.Decimal}");

        Console.WriteLine("Присвоение знаменателю числа ноль");

        try
        {
            var fake = new Rational(1, 0);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("Упрощение дробей");

        var number = new Rational(3, 9);
        Console.WriteLine($"Число до упрощения = {number}");
        var simplified = number.Simplify();
        Console.WriteLine($"Число после упрощения = {simplified}");

        ConsoleHelper.PrintFooter();
    }
}