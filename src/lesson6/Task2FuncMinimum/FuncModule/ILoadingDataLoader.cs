namespace Task2FuncMinimum.FuncModule;

public interface ILoadingDataLoader
{
    double GetMinFromFile(string filename);
    IEnumerable<double> GetValuesAndMinFromFile(string filename, out double minValue);
}