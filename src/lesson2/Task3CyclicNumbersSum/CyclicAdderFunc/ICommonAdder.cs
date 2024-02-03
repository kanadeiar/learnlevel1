namespace Task3CyclicNumbersSum.CyclicAdderFunc;

public interface ICommonAdder : IDataAdder, IAddingAdder, ICalculatingAdder
{

}

public interface IDataAdder
{
    public IEnumerable<int> Numbers { get; }
}

public interface IAddingAdder
{
    public bool AddNumber(int number);
}

public interface ICalculatingAdder
{
    public int SumPlusOdd();
}