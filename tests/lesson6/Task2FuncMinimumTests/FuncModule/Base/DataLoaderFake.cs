namespace Task2FuncMinimumTests.FuncModule.Base;

public class DataLoaderFake : DataLoader
{
    private DataLoaderFake(IBinaryReader reader)
    {
        Reader = reader;
    }

    public static ILoadingDataLoader Create(IBinaryReader reader)
    {
        return new DataLoaderFake(reader);
    }
}