using Kanadeiar.Common;

namespace CommonTests
{
    public class ConsoleHelperTests
    {
        [Fact]
        public void TestPrintHeader()
        {
            using var writer = new StringWriter();
            Console.SetOut(writer);

            ConsoleHelper.PrintHeader("Test", "TestText");

            Assert.Equal("Test", Console.Title);
            var text = writer.ToString();
            Assert.Contains("TestText", text);
        }
    }
}