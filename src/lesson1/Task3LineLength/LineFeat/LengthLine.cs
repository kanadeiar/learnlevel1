namespace Task3LineLength.LineFeat;

public class LengthLine : Line
{
    public LengthLine(Point pointStart, Point pointEnd) : base(pointStart, pointEnd)
    {
    }

    public override double Length()
    {
        return Math.Sqrt(Math.Pow(PointEnd.X - PointStart.X, 2) + Math.Pow(PointEnd.Y - PointStart.Y, 2));
    }
}