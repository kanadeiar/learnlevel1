using FluentAssertions;

namespace Task3LineLengthTests.LineFeat;

public class LineTests
{
    [Theory, MemberData(nameof(ValuesSource), "")]
    public void TestData(Point start, Point end)
    {
        IValuesLine line = Line.Create(start, end);

        line.PointStart.Should().Be(start);
        line.PointEnd.Should().Be(end);
    }

    [Theory, MemberData(nameof(ValuesSource), "digital" )]
    public void TestLengthFormula(Point start, Point end, double expected)
    {
        ILengthLine line = Line.Create(start, end);

        var actual = line.Length();

        actual.Should().Be(expected);
    }

    [Theory, MemberData(nameof(ValuesSource), "text")]
    public void TestLengthText(Point start, Point end, string expected)
    {
        ILengthLine line = Line.Create(start, end);
        
        var actual = line.TextLength();

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> ValuesSource(string variant)
    {
        switch (variant)
        {
            case "digital":
                yield return new object[] { new Point(2, 2), new Point(3, 3), 1.4142135623730951 };
                yield return new object[] { new Point(3, 3), new Point(5, 5), 2.8284271247461903 };
                break;
            case "text":
                yield return new object[] { new Point(2, 2), new Point(3, 3), "1.41" };
                yield return new object[] { new Point(3, 3), new Point(5, 5), "2.83" };
                break;
            default:
                yield return new object[] { new Point(2, 2), new Point(5, 5) };
                break;
        }
    }
}