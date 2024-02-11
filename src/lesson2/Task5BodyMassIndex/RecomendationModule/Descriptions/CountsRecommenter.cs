namespace Task5BodyMassIndex.RecomendationModule.Descriptions;

public class CountsRecommenter : Recommender
{
    public override string RecommendationText(IndexCalculatorModuleAdapter calculator)
    {
        var height = calculator.Height;
        var standardWeightMin = 30 * (height * height); //стандартный вес по росту минимум
        var standardWeightMax = 35 * (height * height); //стандартный вес по росту максимум
        var weight = calculator.Weight;
        var result = Index(calculator) switch
        {
            double d when d < 30 => $"Человеку для того чтобы имено нормальный ИМТ (Легкое ожирение) нужно поправится " +
                                    $"на {(standardWeightMin - weight).ToString("F1", CultureInfo.InvariantCulture)} килограмм.",
            double d when d > 35 => $"Человеку для того чтобы имено нормальный ИМТ (Легкое ожирение) нужно похудеть " +
                                    $"на {(weight - standardWeightMax).ToString("F1", CultureInfo.InvariantCulture)} килограмм.",
            _ => "Нормальный вес, корректировка не требуется.",
        };
        return result;
    }
}