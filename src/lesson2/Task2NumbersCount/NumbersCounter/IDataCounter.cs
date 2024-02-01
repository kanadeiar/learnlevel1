namespace Task2NumbersCount.NumbersCounter;

public interface ICommonCounter : ICountCounter, IDataCounter
{

}

public interface IDataCounter
{
    int Number { get; }
}

public interface ICountCounter
{
    int GetCount();
}