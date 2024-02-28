namespace Task2FuncMinimum.FuncModule;

public class DataLoader
{
    protected IBinaryReader? Reader;

    public double GetMinFromFile(string filename)
    {
        using var stream = Reader is null ? new FileStream(filename, FileMode.Open, FileAccess.Read) : null!;
        using IBinaryReader reader = Reader ??= new BinaryReaderAdapter(stream);

        var min = double.MaxValue;
        while (reader.PeekChar() > -1)
        {
            var current = reader.ReadDouble();
            if (current < min)
            {
                min = current;
            }
        }
        return min;
    }

    public IEnumerable<double> GetValuesAndMinFromFile(string filename, out double minValue)
    {
        using var stream = Reader is null ? new FileStream(filename, FileMode.Open, FileAccess.Read) : null!;
        using IBinaryReader reader = Reader ??= new BinaryReaderAdapter(stream);

        var min = double.MaxValue;
        var values = new List<double>();
        while (reader.PeekChar() > -1)
        {
            var current = reader.ReadDouble();
            if (current < min)
            {
                min = current;
            }
            values.Add(current);
        }
        minValue = min;
        return values;
    }
}