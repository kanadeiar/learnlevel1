namespace Task2FuncMinimum.FuncModule.Adapters;

public interface IBinaryReader : IDisposable
{
    double PeekChar();
    double ReadDouble();
}