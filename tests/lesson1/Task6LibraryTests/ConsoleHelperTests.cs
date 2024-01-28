using Kanadeiar.Common;

namespace Task6LibraryTests;

public class ConsoleHelperTests
{
    [Fact]
    public void TestPrintHeader()
    {
        using var writer = new StringWriter();
        var old = Console.Out;
        Console.SetOut(writer);

        ConsoleHelper.PrintHeader("TestTitle", "TestText");

        var text = writer.ToString();

        Assert.Equal("TestTitle", Console.Title);
        Assert.Contains("TestText", text);

        Console.SetOut(old);
    }

}