namespace Task1FunctionsTableTests.FunctionsTableFunc;

public class MessagesGeneratorTests
{
    [Theory, MemberData(nameof(MessagesGeneratorSource))]
    public void TestGenerateTableMessage(FunctionsSource.Fun fun, string expected, double a, double x, double end)
    {
        var generator = new MessagesGenerator();

        var actual = generator.GenerateTableMessage(fun, a, x, end);

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> MessagesGeneratorSource()
    {
        var fun = new FunctionsSource.Fun((a, x) => a + x);
        var expected =
$@"┌─────────────────────────────────┐
|-------- A -------- X -------- Y |
|    1.000 |    1.000 |    2.000  |
|    1.000 |    2.000 |    3.000  |
|    1.000 |    3.000 |    4.000  |
└─────────────────────────────────┘
";
        yield return [fun, expected, 1.0, 1.0, 3.0];
    }
}