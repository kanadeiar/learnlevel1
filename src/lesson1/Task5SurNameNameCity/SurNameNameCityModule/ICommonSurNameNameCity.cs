namespace Task5SurNameNameCity.SurNameNameCityModule;

public interface ICommonSurNameNameCity : ITextSurNameNameCity
{
    string SurName { get; }
    string Name { get; }
    string City { get; }
}

public interface ITextSurNameNameCity
{
    string GetText();
}