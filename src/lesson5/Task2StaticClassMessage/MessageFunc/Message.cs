namespace Task2StaticClassMessage.MessageFunc;

public static class Message
{
    public static IEnumerable<string> GetWordsWhenMinLength(string message, int minLength)
    {
        var words = message.Split(' ');
        var filterWords = words.Where(w => w.Length <= minLength).Distinct();
        return filterWords;
    }

    public static string MessageWithRemovedWords(string message, char lastLetter)
    {
        var wordsRegex = new Regex($@"\w+{lastLetter}\b");
        var withoutWords = wordsRegex.Replace(message, string.Empty);
        var spaceRegex = new Regex("[ ]{2,}");
        var result = spaceRegex.Replace(withoutWords, " ").Trim();
        return result;
    }

    public static string LongestWord(string message)
    {
        var words = message.Split(' ');
        Array.Sort(words, (s, s1) => s.Length - s1.Length);
        return words.Last();
    }

    public static string LongWordsMessage(string message)
    {
        var max = LongestWord(message).Length;
        var regex = new Regex(@"\w{" + max + @"}\b");
        var result = new StringBuilder();
        var collection = regex.Matches(message);
        foreach (var elem in collection)
        {
            result.Append($"{elem} ");
        }

        return result.ToString().Trim();
    }

    public static IDictionary<string, int> FrequencyAnalysisDictionary(string message)
    {
        var result = new Dictionary<string, int>();
        var words = message.Split(' ');
        foreach (var elem in words)
        {
            if (result.TryAdd(elem, 1) == false)
            {
                result[elem]++;
            }
        }

        return result;
    }
}