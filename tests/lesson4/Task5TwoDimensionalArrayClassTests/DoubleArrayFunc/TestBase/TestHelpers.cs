namespace Task5TwoDimensionalArrayClassTests.DoubleArrayFunc.TestBase;

public class TestHelpers
{
    public static void AssertValuesInArray(DoubleArray array, string[] lines)
    {
        var arrSize = lines[0].Split(',');
        var rowCount = int.Parse(arrSize[0]);
        var colCount = int.Parse(arrSize[1]);
        array.ColCount.Should().Be(colCount);
        array.RowCount.Should().Be(rowCount);

        for (var i = 0; i < rowCount; i++)
        {
            var values = lines[i + 1].Split(',');
            for (var j = 0; j < colCount; j++)
            {
                array[i, j].Should().Be(int.Parse(values[j]));
            }
        }
    }

    public static void AssertRandomValuesInArray(DoubleArray array)
    {
        for (int i = 0; i < array.RowCount; i++)
        {
            for (int j = 0; j < array.ColCount; j++)
            {
                array[i, j].Should().BeInRange(0, 1001);
            }
        }
    }
}