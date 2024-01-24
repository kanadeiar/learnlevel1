using System.Drawing;

namespace Lesson1LineLength.LineFeat;

public interface ICommonLine : ILengthLine
{
    Point PointStart { get; set; }
    Point PointEnd { get; set; }
}

public interface ILengthLine
{
    double Length();
    string TextLength();
}