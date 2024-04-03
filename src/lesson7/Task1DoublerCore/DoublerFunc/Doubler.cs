namespace Task1DoublerCore.DoublerFunc;

public class Doubler : ModelBase, ICommonDoubler
{
    public event EventHandler<StartedEventArgs>? OnStarted
    {
        add => _game.onStarted += value;
        remove => _game.onStarted -= value;
    }

    public event EventHandler<WonEventArgs>? OnWon
    {
        add => _game.onWon += value;
        remove => _game.onWon -= value;
    }

    private readonly DoublerCore _core;
    private readonly Game _game;

    private int _number;

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

    private int _winNumber;

    public int WinNumber
    {
        get => _winNumber;
        set => Set(ref _winNumber, value);
    }

    public Doubler()
    {
        _core = new DoublerCore(this);
        _game = new Game(this);
    }
    
    public void Increment()
    {
        _core.increment();
        _game.checkWinGame(Number == WinNumber);
    }

    public void Double()
    {
        _core.@double();
        _game.checkWinGame(Number == WinNumber);
    }

    public void Reset()
    {
        _core.reset();
        _game.checkWinGame(Number == WinNumber);
    }

    public void Undo()
    {
        _core.undo();
    }

    public void Start()
    {
        _core.reset();
        _game.startGame();
    }
}