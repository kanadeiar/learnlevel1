namespace Task1DoublerCore.DoublerFunc.Core;

internal class DoublerCore(IValueingDoubler doubler)
{
    private Stack<int> _history = new();

    internal void increment()
    {
        _history.Push(doubler.Number);

        doubler.Number++;
        doubler.Count++;
    }

    internal void @double()
    {
        _history.Push(doubler.Number);

        doubler.Number *= 2;
        doubler.Count++;
    }

    internal void reset()
    {
        _history.Clear();

        doubler.Number = 0;
        doubler.Count = 0;
    }

    internal void undo()
    {
        if (doubler.Count == 0) return;
        if (_history.Count == 0) return;

        doubler.Number = _history.Pop();
        doubler.Count--;
    }
}