namespace Lesson1Anketa.AnketaFeat;

public class Anketa
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Anketa(string name)
    {
        _name = name;
    }
}