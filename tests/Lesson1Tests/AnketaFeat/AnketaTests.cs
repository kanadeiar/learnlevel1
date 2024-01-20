using Lesson1Anketa.AnketaFeat;

namespace Lesson1Tests.AnketaFeat;

public class AnketaTests
{
    [Fact]
    public void TestName()
    {
        var anketa = new Anketa("default");

        anketa.Name = "Test";

        Assert.Equal("Test", anketa.Name);
    }
}