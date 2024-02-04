namespace Task3LineLength.LineFeat;

public abstract class Line : ICommonLine
{
    private Point _pointStart;

    public Point PointStart => _pointStart;

    private Point _pointEnd;

    public Point PointEnd => _pointEnd;

    protected Line(Point pointStart, Point pointEnd)
    {
        _pointStart = pointStart;
        _pointEnd = pointEnd;
    }

    public static LengthLine Create(Point pStart, Point pEnd)
    {
        return new LengthLine(pStart, pEnd);
    }

    public abstract double Length();

    public string TextLength()
    {
        return Length().ToString("F2", NumberFormatInfo.InvariantInfo);
    }
}