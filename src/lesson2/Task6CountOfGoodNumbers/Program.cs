using Kanadeiar.Common;

ConsoleHelper.PrintHeader("Задача № 6", "Задача № 6. Подсчет количества \"хороших\" чисел.");

var counter = new Counter();
var meter = TimeMeter.Start();

var count = counter.Count(1_000_000_000);

var time = meter.Stop();

Console.WriteLine("Количество хороших чисел: {0}", count);

Console.WriteLine("Время выполнения программы: {0}", time);

ConsoleHelper.PrintFooter();
