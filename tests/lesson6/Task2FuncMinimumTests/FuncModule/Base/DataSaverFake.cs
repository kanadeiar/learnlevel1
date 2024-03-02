namespace Task2FuncMinimumTests.FuncModule.Base;

public class DataSaverFake : DataSaver
{
    private DataSaverFake(IBinaryWriter writer)
    {
        Writer = writer;
    }

    public static ISavingDataSaver Create(IBinaryWriter writer)
    {
        return new DataSaverFake(writer);
    }
}