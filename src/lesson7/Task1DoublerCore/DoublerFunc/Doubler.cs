namespace Task1DoublerCore.DoublerFunc;

public class Doubler : ModelBase, ICommonDoubler
{
    private int _number = 1;

    public int Number
    {
        get => _number;
        set => Set(ref _number, value);
    }

    private int _count;

    public int Count
    {
        get => _count;
        set => Set(ref _count, value);
    }

    public void Increment()
    {
        Number++;
        Count++;
    }

    public void Double()
    {
        Number *= 2;
        Count++;
    }

    public void Reset()
    {
        Number = 1;
        Count = 0;
    }
}