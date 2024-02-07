namespace Task5BodyMassIndex.RecomendationModule.Descriptions;

public class CountsRecommenter : Recommender
{
    public override string RecommendationText(ICommonCalculator calculator)
    {
        var standardWeightMin = 30 * (calculator.Height * calculator.Height); //стандартный вес по росту минимум
        var standardWeightMax = 35 * (calculator.Height * calculator.Height); //стандартный вес по росту максимум
        var result = Index(calculator) switch
        {
            double d when d < 30 => $"Человеку для того чтобы имено нормальный ИМТ (Легкое ожирение) нужно поправится " +
                                    $"на {(standardWeightMin - calculator.Weight).ToString("F1", CultureInfo.InvariantCulture)} килограмм.",
            double d when d > 35 => $"Человеку для того чтобы имено нормальный ИМТ (Легкое ожирение) нужно похудеть " +
                                    $"на {(calculator.Weight - standardWeightMax).ToString("F1", CultureInfo.InvariantCulture)} килограмм.",
            _ => "Нормальный вес, корректировка не требуется.",
        };
        return result;
    }
}