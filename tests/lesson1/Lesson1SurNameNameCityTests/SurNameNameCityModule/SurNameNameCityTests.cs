using Lesson1SurNameNameCity.SurNameNameCityModule;

namespace Lesson1SurNameNameCityTests.SurNameNameCityModule;

public class SurNameNameCityTests
{
    [Fact]
    public void TestValues()
    {
        var data = SurNameNameCity.CreateInstance("SurName", "Name", "Kuzneck");

        Assert.Equal("SurName", data.SurName);
        Assert.Equal("Name", data.Name);
        Assert.Equal("Kuzneck", data.City);
    }

    [Fact]
    public void GetText()
    {
        var data = SurNameNameCity.CreateInstance("SurName", "Name", "Kuzneck");

        var actual = data.GetText();

        Assert.Equal("Фамилия: SurName Имя: Name Город: Kuzneck", actual);
    }
}