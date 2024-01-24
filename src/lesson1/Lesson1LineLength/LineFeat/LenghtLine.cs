using System.Drawing;

namespace Lesson1LineLength.LineFeat;

public class LenghtLine : Line
{
    public LenghtLine(Point pointStart, Point pointEnd) : base(pointStart, pointEnd)
    {
    }

    public override double Length()
    {
        return Math.Sqrt(Math.Pow(PointEnd.X - PointStart.X, 2) + Math.Pow(PointEnd.Y - PointStart.Y, 2));
    }
}