namespace Task2FuncMinimum.FuncModule;

public interface ISavingDataSaver
{
    void SaveDataFromFunc(DataSaver.Func func, string filename, double start, double end, double step);
}