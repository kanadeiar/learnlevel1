using Lesson1Anketa.AnketaFeat;

namespace Lesson1Tests.AnketaFeat;

public class AnketaTests : IClassFixture<AnketaFixture>
{
    private readonly Anketa _anketa;

    public AnketaTests(AnketaFixture fixture)
    {
        _anketa = fixture.Anketa;
    }

    [Fact]
    public void TestData()
    {
        _anketa.Name = "Test";
        _anketa.SurName = "TestFam";
        _anketa.Age = 20;
        _anketa.Height = 180;
        _anketa.Weight = 79;

        Assert.Equal("Test", _anketa.Name);
        Assert.Equal("TestFam", _anketa.SurName);
        Assert.Equal(20, _anketa.Age);
        Assert.Equal(180, _anketa.Height);
        Assert.Equal(79, _anketa.Weight);
    }

    
}