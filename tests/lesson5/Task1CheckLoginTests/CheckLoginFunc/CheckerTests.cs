using FluentAssertions;

namespace Task1CheckLoginTests.CheckLoginFunc;

public class CheckerTests
{
    [Fact]
    public void TestChecker()
    {
        true.Should().BeTrue();
    }
}