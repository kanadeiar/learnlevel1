namespace Task5BodyMassIndex.RecomendationModule.Descriptions;

public class MessagesRecommender : Recommender
{
    public override string RecommendationText(IndexCalculatorModuleAdapter calculator)
    {
        var result = Index(calculator) switch
        {
            double d when d < 16.0 => "Выраженный дефицит массы тела. Немедленно набрать очень много веса!",
            double d when d < 18.9 => "Недостаточная (дефицит) масса тела. Очень срочно набрать вес!",
            double d when d < 24.99 => "Норма. Срочно набрать вес!",
            double d when d < 30.0 => "Избыточная масса тела (предожирение). Немного набрать вес.",
            double d when d < 35.0 => "Ожирение (на самом деле это нормальный вес!). Все в порядке!",
            double d when d < 40.0 => "Ожирение начальное. Немножечко сбросить вес!",
            _ => "Очень сильное ожирение. Срочно сбросить вес!",
        };
        return result;
    }
}