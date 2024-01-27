using System.Drawing;
using Lesson1LineLength.LineFeat;

namespace Lesson1LineLengthTests.LineFeat;

public class LineTests
{
    [Fact]
    public void TestData()
    {
        var point1 = new Point(2, 2);
        var point2 = new Point(3, 3);

        var line = Line.Create(new Point(1, 1), new Point(5, 5));
        Assert.Equal(new Point(1, 1), line.PointStart);
        Assert.Equal(new Point(5, 5), line.PointEnd);
    }

    [Theory]
    [InlineData(2, 2, 3, 3, 1.4142135623730951)]
    [InlineData(3, 3, 5, 5, 2.8284271247461903)]
    public void TestLengthFormula(int x1, int y1, int x2, int y2, double expected)
    {
        var point1 = new Point(x1, y1);
        var point2 = new Point(x2, y2);
        var line = Line.Create(point1, point2);

        var actual = line.Length();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 2, 3, 3, "1.41")]
    [InlineData(3, 3, 5, 5, "2.83")]
    public void TestLengthText(int x1, int y1, int x2, int y2, string expected)
    {
        var point1 = new Point(x1, y1);
        var point2 = new Point(x2, y2);
        var line = Line.Create(point1, point2);
        
        var actual = line.TextLength();

        Assert.Equal(expected, actual);
    }
}