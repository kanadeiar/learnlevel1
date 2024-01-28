namespace Task3LineLength.LineFeat;

public interface ICommonLine : ILengthLine
{
    Point PointStart { get; }
    Point PointEnd { get; }
}

public interface ILengthLine
{
    double Length();
    string TextLength();
}