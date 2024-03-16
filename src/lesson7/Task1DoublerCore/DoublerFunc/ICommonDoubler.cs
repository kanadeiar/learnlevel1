namespace Task1DoublerCore.DoublerFunc;

public interface ICommonDoubler : IValueingDoubler, IControllingDoubler, IGameingDoubler
{
}

public interface IValueingDoubler : IFormObservable
{
    int Number { get; set; }
    int Count { get; set; }
    int WinNumber { get; set; }
}

public interface IControllingDoubler
{
    void Increment();
    void Double();
    void Reset();
}

public interface IGameingDoubler
{
    event EventHandler<StartedEventArgs>? OnStarted;
    event EventHandler<WinEventArgs>? OnWin;
    
    void Start();
}