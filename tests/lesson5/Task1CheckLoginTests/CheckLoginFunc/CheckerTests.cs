namespace Task1CheckLoginTests.CheckLoginFunc;

public class CheckerTests
{
    [Theory, MemberData(nameof(LoginsSource))]
    public void TestCheck_WhenSimple(string? login, bool expected)
    {
        ICheckingChecker checker = Checker.Create(CheckCode.Simple);

        var actual = checker.Check(login);

        actual.Should().Be(expected);
    }    
    
    [Theory, MemberData(nameof(LoginsSource))]
    public void TestCheck_WhenWithRegex(string? login, bool expected)
    {
        ICheckingChecker checker = Checker.Create(CheckCode.WithRegex);

        var actual = checker.Check(login);

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> LoginsSource()
    {
        yield return ["login", true];
        yield return ["ab", true];
        yield return ["a1", true];
        yield return ["admin", true];
        yield return ["a12345678", true];
        yield return ["a", false];
        yield return ["1233", false];
        yield return ["1", false];
        yield return ["1aaaaa", false];
        yield return ["adminadminadminasdfdsffsdaf", false];
    }

    [Fact]
    public void TestCheck_WhenNullLogin_ThenFalse()
    {
        ICheckingChecker checker = Checker.Create(CheckCode.Simple);

        var actual = checker.Check(null);

        actual.Should().BeFalse();
    }
}