using Task5BodyMassIndex.RecomendationModule.Descriptions;

namespace Task5BodyMassIndex.RecomendationModule;

public abstract class Recommender : ITextRecommender
{
    protected Recommender()
    {
        
    }

    public static ITextRecommender Create(RecommenderType type)
    {
        switch (type)
        {
            case RecommenderType.Messages:
                return new MessagesRecommender();
            case RecommenderType.Counts:
                return new CountsRecommenter();
            default:
                return new NoneRecommender();
        }

    }

    public abstract string RecommendationText(ICommonCalculator calculator);

    protected static double Index(ICommonCalculator calculator)
    {
        var index = calculator.Index();
        return index;
    }
}