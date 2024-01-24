using Lesson1Anketa.AnketaFeat.TextFormat;

namespace Lesson1Anketa.AnketaFeat;

public interface IFaсtoryAnketa : IPropertiesAnketa, ITextGeneratingAnketa
{

}

public interface IPropertiesAnketa
{
    string? Name { get; set; }
    string? SurName { get; set; }
    int Age { get; set; }
    int Height { get; set; }
    int Weight { get; set; }
}

public interface ITextGeneratingAnketa
{
    string GetText(TextFormatCode typ);
}