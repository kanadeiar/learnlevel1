using Lesson1Anketa.AnketaFeat.TextFormat;

namespace Lesson1Anketa.AnketaFeat;

internal class Anketa : IFaсtoryAnketa
{
    private string _name = string.Empty;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    private string _surName;

    public string SurName
    {
        get => _surName;
        set => _surName = value;
    }

    private int _age;

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    private int _height;

    public int Height
    {
        get => _height;
        set => _height = value;
    }

    private int _weight;

    public int Weight
    {
        get => _weight;
        set => _weight = value;
    }
    
    private FormatBase _typ;

    internal Anketa()
    {
    }

    public string GetText(TextFormatType typ)
    {
        _typ = FormatBase.Create(typ);
        return formTextLineFromProperties();
    }

    private string formTextLineFromProperties()
    {
        return _typ.GetText(this);
    }
}