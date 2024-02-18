using Kanadeiar.Common.Console;

ConsoleHelper.PrintHeader("Задача № 7", "Задача № 7. Рекурсивный метод.");

Console.WriteLine("Вывод чисел от 1 до 100:");

var textExecutor = RecursiveExecutor.Create<string>(AlgorithmCode.Text);
var text = textExecutor.RecursiveExecute(1, 100);
Console.WriteLine(text);

Console.WriteLine("Подсчет суммы чисел от 1 до 100:");

var sumExecutor = RecursiveExecutor.Create<long>(AlgorithmCode.Sum);
var sum = sumExecutor.RecursiveExecute(1, 100);
Console.WriteLine(sum);

ConsoleHelper.PrintFooter();
