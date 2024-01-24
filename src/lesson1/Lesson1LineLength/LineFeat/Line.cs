using System.Drawing;
using System.Globalization;

namespace Lesson1LineLength.LineFeat;

public class Line : ICommonLine
{
    private Point _pointStart;

    public Point PointStart
    {
        get => _pointStart;
        set => _pointStart = value;
    }

    private Point _pointEnd;

    public Point PointEnd
    {
        get => _pointEnd;
        set => _pointEnd = value;
    }

    private Line(Point pointStart, Point pointEnd)
    {
        _pointStart = pointStart;
        _pointEnd = pointEnd;
    }
    public static Line Create(Point pStart, Point pEnd)
    {
        return new Line(pStart, pEnd);
    }

    public double Length()
    {
        var result = Math.Sqrt(Math.Pow(PointEnd.X - PointStart.X, 2) + Math.Pow(PointEnd.Y - PointStart.Y, 2));
        return result;
    }

    public string TextLength()
    {
        return Length().ToString("F2", NumberFormatInfo.InvariantInfo);
    }
}