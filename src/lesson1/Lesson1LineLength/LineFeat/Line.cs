using System.Drawing;
using System.Globalization;

namespace Lesson1LineLength.LineFeat;

public abstract class Line : ICommonLine
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

    protected Line(Point pointStart, Point pointEnd)
    {
        _pointStart = pointStart;
        _pointEnd = pointEnd;
    }
    public static LenghtLine Create(Point pStart, Point pEnd)
    {
        return new LenghtLine(pStart, pEnd);
    }

    public abstract double Length();

    public string TextLength()
    {
        return Length().ToString("F2", NumberFormatInfo.InvariantInfo);
    }
}