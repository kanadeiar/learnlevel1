namespace Task5BodyMassIndex.RecomendationModule.Descriptions;

public class NoneRecommender : ITextRecommender
{
    public string RecommendationText(IndexCalculatorModuleAdapter calculator) => string.Empty;
}