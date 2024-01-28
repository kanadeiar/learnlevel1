using Task5SurNameNameCity.SurNameNameCityModule;

namespace Task5SurNameNameCityTests.SurNameNameCityModule;

public class SurNameNameCityTests
{
    private ICommonSurNameNameCity _data;

    public SurNameNameCityTests()
    {
        _data = SurNameNameCity.CreateInstance("SurName", "Name", "Kuzneck");
    }

    [Fact]
    public void TestValues()
    {
        Assert.Equal("SurName", _data.SurName);
        Assert.Equal("Name", _data.Name);
        Assert.Equal("Kuzneck", _data.City);
    }

    [Fact]
    public void GetText()
    {
        var actual = _data.GetText();

        Assert.Equal("Фамилия: SurName Имя: Name Город: Kuzneck", actual);
    }
}