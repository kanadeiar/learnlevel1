namespace Task3BestArrayClassTests.BestArrayFunc.TestBase;

public class TestHelper
{
    public static string CreateExpected(IInfoBestArray array)
    {
        var expected = string.Empty;
        for (var i = 0; i < array.Length; i++)
        {
            expected += $"{array[i],4} ";
        }

        return expected;
    }

    public static void AssertValuesInArray(IInfoBestArray array, int[]? expected = null)
    {
        array.Length.Should().Be(expected!.Length);
        for (int i = 0; i < array.Length; i++)
        {
            array[i].Should().Be(expected[i]);
        }
    }

    public static void AssertRandomValuesInArray(IInfoBestArray array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i].Should().BeInRange(1, 101);
        }
    }
}