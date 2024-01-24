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

        line.PointStart = point1;
        line.PointEnd = point2;
        
        Assert.Equal(new Point(2, 2), line.PointStart);
        Assert.Equal(new Point(3, 3), line.PointEnd);
    }

    [Fact]
    public void TestFormula()
    {
        var point1 = new Point(2, 2);
        var point2 = new Point(3, 3);
        var line = Line.Create(point1, point2);
        var lengthOfLine = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

        var actual = line.Length();

        Assert.Equal(lengthOfLine, actual);
    }
}