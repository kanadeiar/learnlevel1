namespace Task5BodyMassIndex.RecomendationModule;

public interface ITextRecommender
{
    string RecommendationText(IndexCalculatorModuleAdapter calculator);
}