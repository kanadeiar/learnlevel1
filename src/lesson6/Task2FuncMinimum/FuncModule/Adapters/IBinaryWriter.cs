namespace Task2FuncMinimum.FuncModule.Adapters;

public interface IBinaryWriter : IDisposable
{
    void Write(double value);
}