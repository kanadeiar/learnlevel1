using Kanadeiar.Common;

ConsoleHelper.PrintHeader("Задача № 5", "Задача № 5. Рекомендации по индексу массы тела.");

var weight = ConsoleHelper.ReadNumberFromConsole<double>("Введите вес в кг");
var height = ConsoleHelper.ReadNumberFromConsole<double>("Введите рост в метрах");

var calculator = new Calculator(weight, height);

Console.WriteLine(calculator.Print());

Console.WriteLine("Рекомендации:");

var messagesRecommender = Recommender.Create(RecommenderType.Messages);
Console.WriteLine(messagesRecommender.RecommendationText(calculator));

var counterRecommender = Recommender.Create(RecommenderType.Counts);
Console.WriteLine(counterRecommender.RecommendationText(calculator));

ConsoleHelper.PrintFooter();
