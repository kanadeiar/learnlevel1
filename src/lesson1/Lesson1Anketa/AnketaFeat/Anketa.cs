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

    internal Anketa()
    {
    }

    public string GetGluedLine()
    {
        return SurName + " " + Name + " " + Age + " лет " + Height + " см " + Weight + " кг";
    }

    public string GetFormatted()
    {
        return string.Format("Formatted {0} {1} {2} лет {3} см {4} кг", SurName, Name, Age, Height, Weight);
    }

    public string GetInterpolated()
    {
        return $"""{SurName} {Name} {Age} лет {Height} см {Weight} кг""";
    }
}