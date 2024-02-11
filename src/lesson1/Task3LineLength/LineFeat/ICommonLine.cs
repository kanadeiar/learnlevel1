namespace Task3LineLength.LineFeat;

public interface ICommonLine : ILengthLine, IValuesLine
{
}

public interface IValuesLine
{
    Point PointStart { get; }
    Point PointEnd { get; }
}

public interface ILengthLine
{
    double Length();
    string TextLength();
}