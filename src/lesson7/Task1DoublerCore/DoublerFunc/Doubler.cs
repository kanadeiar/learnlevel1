namespace Task1DoublerCore.DoublerFunc;

public class Doubler : ModelBase, ICommonDoubler
{
    private int _number = 1;

    public int Number
    {
        get => _number;
        set => Set(ref _number, value);
    }

    public void Increment()
    {
        Number++;
    }

    public void Double()
    {
        Number *= 2;
    }

    public void Reset()
    {
        Number = 1;
    }
}