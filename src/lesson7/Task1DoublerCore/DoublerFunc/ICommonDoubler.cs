namespace Task1DoublerCore.DoublerFunc;

public interface ICommonDoubler : IValueingDoubler, IControlingDoubler
{
}

public interface IValueingDoubler : IFormObservable
{
    int Number { get; set; }
}

public interface IControlingDoubler
{
    void Increment();
    void Double();
    void Reset();
}