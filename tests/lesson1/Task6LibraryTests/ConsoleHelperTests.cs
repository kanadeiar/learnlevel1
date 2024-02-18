using Kanadeiar.Common.Console;

namespace Task6LibraryTests;

public class ConsoleHelperTests
{
    [Fact]
    public void TestPrintHeader()
    {
        using var writer = new StringWriter();
        var old = Console.Out;
        Console.SetOut(writer);

        ConsoleHelper.OutputHeaderToConsole("TestText");

        var text = writer.ToString();

        text.Should().Contain("TestText");

        Console.SetOut(old);
    }

}