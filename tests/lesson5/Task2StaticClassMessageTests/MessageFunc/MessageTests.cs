namespace Task2StaticClassMessageTests.MessageFunc;

public class MessageTests
{
    [Theory, MemberData(nameof(MessageSource))]
    public void TestGetWordsWhenMinLength(string message)
    {
        var actual = Message.GetWordsWhenMinLength(message, 6).ToArray();

        actual.Should().HaveCount(6);
        actual.Should().Contain(["Is", "this", "one", "good", "var"]);
    }

    [Theory, MemberData(nameof(MessageSource))]
    public void TestMessageWithRemovedWords(string message)
    {
        var actual = Message.MessageWithRemovedWords(message, 's');

        actual.Should().Be("one good good message processing insumation message good var");
    }

    [Theory, MemberData(nameof(MessageSource))]
    public void TestLongestWord(string message)
    {
        var actual = Message.LongestWord(message);

        actual.Should().Be("insumation");
    }

    [Theory, MemberData(nameof(MessageSource))]
    public void TestLongWordsMessage(string message)
    {
        var actual = Message.LongWordsMessage(message);

        actual.Should().Be("processing insumation");
    }

    [Theory, MemberData(nameof(MessageSource))]
    public void TestFrequencyAnalysisDictionary(string message)
    {
        var expected = new[] { ("Is", 1), ("message", 2), ("good", 3) }
            .Select(x => new KeyValuePair<string, int>(x.Item1, x.Item2));

        var actual = Message.FrequencyAnalysisDictionary(message);

        actual.Should().HaveCount(9);
        actual.Should().Contain(expected);
    }

    public static IEnumerable<object[]> MessageSource()
    {
        yield return new object[] { "Is this one good good message processing lorems insumation lorems message good var" };
    }
}