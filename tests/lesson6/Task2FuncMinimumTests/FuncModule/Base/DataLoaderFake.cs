namespace Task2FuncMinimumTests.FuncModule.Base;

public class DataLoaderFake : DataLoader
{
    public DataLoaderFake(IBinaryReader reader)
    {
        Reader = reader;
    }
}