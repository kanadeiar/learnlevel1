namespace Task5TwoDimensionalArrayClassTests.DoubleArrayFunc.TestBase;

public class TestHelpers
{
    public static void AssertValuesInArray(DoubleArray array)
    {
        for (int i = 0; i < array.ColCount; i++)
        {
            for (int j = 0; j < array.RowCount; j++)
            {
                array[i, j].Should().BeInRange(0, 1001);
            }
        }
    }
}