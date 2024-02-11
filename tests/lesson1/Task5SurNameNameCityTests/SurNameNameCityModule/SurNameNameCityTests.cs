using FluentAssertions;

namespace Task5SurNameNameCityTests.SurNameNameCityModule;

public class SurNameNameCityTests
{
    [Theory, MemberData(nameof(ValuesSource))]
    public void TestValues(string surName, string name, string city)
    {
        ICommonSurNameNameCity _data = new SurNameNameCity(surName, name, city);

        _data.SurName.Should().Be(surName);
        _data.Name.Should().Be(name);
        _data.City.Should().Be(city);
    }

    [Theory, MemberData(nameof(ValuesSource))]
    public void GetText(string surName, string name, string city)
    {
        ITextSurNameNameCity _data = new SurNameNameCity(surName, name, city);

        var actual = _data.GetText();

        actual.Should().Be("Фамилия: SurName Имя: Name Город: Kuzneck");
    }

    public static IEnumerable<object[]> ValuesSource()
    {
        yield return new object[] { "SurName", "Name", "Kuzneck" };
    }
}