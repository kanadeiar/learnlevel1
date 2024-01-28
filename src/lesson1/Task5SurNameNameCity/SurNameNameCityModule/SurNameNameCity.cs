namespace Task5SurNameNameCity.SurNameNameCityModule;

public class SurNameNameCity : ICommonSurNameNameCity, ITextSurNameNameCity
{
    private readonly string _surName;

    public string SurName => _surName;
    
    private readonly string _name;

    public string Name => _name;

    private readonly string _city;

    public string City => _city;

    private SurNameNameCity(string surName, string name, string city)
    {
        _surName = surName;
        _name = name;
        _city = city;
    }

    public static ICommonSurNameNameCity CreateInstance(string surName, string name, string city)
    {
        return new SurNameNameCity(surName, name, city);
    }

    public string GetText()
    {
        return $"Фамилия: {SurName} Имя: {Name} Город: {City}";
    }
}