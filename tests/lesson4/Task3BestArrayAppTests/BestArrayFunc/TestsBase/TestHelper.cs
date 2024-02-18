namespace Task3BestArrayClassTests.BestArrayFunc.TestsBase;

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
        if (expected is not null)
        {
            array.Length.Should().Be(expected.Length);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (expected is not null)
            {
                array[i].Should().Be(expected[i]);
            }
            else
            {
                array[i].Should().BeInRange(1, 101);
            }
        }
    }
}