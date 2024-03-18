namespace Task1DoublerCore.DoublerFunc.Base;

internal class DoublerCore(IValueingDoubler doubler)
{
    internal void increment()
    {
        doubler.Number++;
        doubler.Count++;
    }

    internal void @double()
    {
        doubler.Number *= 2;
        doubler.Count++;
    }

    internal void reset()
    {
        doubler.Number = 0;
        doubler.Count = 0;
    }
}