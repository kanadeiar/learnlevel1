namespace Task2FuncMinimum.FuncModule;

public class DataSaver
{
    public delegate double Func(double x);

    protected IBinaryWriter? Writer;

    public void SaveDataFromFunc(Func func, string filename, double start, double end, double step)
    {
        using var stream = Writer is null ? new FileStream(filename, FileMode.Create, FileAccess.Write) : null!;
        using IBinaryWriter writer = Writer ??= new BinaryWriterAdapter(stream);

        var run = start;
        while (run <= end)
        {
            writer.Write(func(run));
            run += step;
        }
    }
}