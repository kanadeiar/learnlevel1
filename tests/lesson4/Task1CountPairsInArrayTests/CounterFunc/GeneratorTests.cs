using Task1CountPairsInArray.CounterFunc;

namespace Task1CountPairsInArrayTests.CounterFunc;

public class GeneratorTests
{
    [Fact]
    public void TestGenerate()
    {
        var generator = new Generator();

        var actuals = generator.Generate(20);

        actuals.Should().HaveCount(20);
        foreach (var each in actuals)
        {
            each.Should().BeInRange(-10_000, 10_000);
        }
    }
}