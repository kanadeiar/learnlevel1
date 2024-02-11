namespace Task2Numbers.NumbersFunc;

public interface ICommonAdder : IValuesAdder, IAddingAdder, ICalculatingAdder
{

}

public interface IValuesAdder
{
    public IEnumerable<int> Numbers { get; }
}

public interface IAddingAdder
{
    public bool AddNumber(int number);
}

public interface ICalculatingAdder
{
    public int SumPlusOddNumbers();
}