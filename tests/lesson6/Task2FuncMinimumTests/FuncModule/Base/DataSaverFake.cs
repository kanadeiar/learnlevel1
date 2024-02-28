namespace Task2FuncMinimumTests.FuncModule.Base;

public class DataSaverFake : DataSaver
{
    public DataSaverFake(IBinaryWriter writer)
    {
        Writer = writer;
    }
}