namespace Task3CyclicNumbersSum.CyclicAdderFunc;

public class Adder : ICommonAdder
{
    public IEnumerable<int> Numbers
    {
        get
        {
            yield return 1;
            yield return 100;
        }
    }

    private Adder()
    {
        
    }

    public static ICommonAdder CreateInstance()
    {
        return new Adder();
    }

    public bool AddNumber(int number)
    {
        return true;
    }
}

public interface ICommonAdder : IDataAdder, IAddingAdder
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

