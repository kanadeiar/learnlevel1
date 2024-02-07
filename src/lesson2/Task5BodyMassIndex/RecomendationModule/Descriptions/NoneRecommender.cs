namespace Task5BodyMassIndex.RecomendationModule.Descriptions;

public class NoneRecommender : ITextRecommender
{
    public string RecommendationText(ICommonCalculator calculator) => string.Empty;
}