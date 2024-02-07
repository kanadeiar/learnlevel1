namespace Task5BodyMassIndex.RecomendationModule;

public interface ITextRecommender
{
    string RecommendationText(ICommonCalculator calculator);
}