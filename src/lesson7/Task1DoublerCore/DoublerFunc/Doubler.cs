namespace Task1DoublerCore.DoublerFunc;

public class Doubler : ModelBase, ICommonDoubler
{
    private EventHandler<StartedEventArgs>? _onStarted;

    public event EventHandler<StartedEventArgs>? OnStarted
    {
        add => _onStarted += value;
        remove => _onStarted -= value;
    }

    private EventHandler<WinEventArgs>? _onWin;

    public event EventHandler<WinEventArgs>? OnWin
    {
        add => _onWin += value;
        remove => _onWin -= value;
    }

    private Random _rnd = new();
    private int _number;

    private bool _started;

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
    
    public void Increment()
    {
        Number++;
        Count++;

        checkWinGame();
    }

    public void Double()
    {
        Number *= 2;
        Count++;

        checkWinGame();
    }

    public void Reset()
    {
        Number = 0;
        Count++;

        checkWinGame();
    }

    private void checkWinGame()
    {
        var isWinInGame = _started && Number == WinNumber;
        if (isWinInGame)
        {
            _started = false;
            onGameWin(new WinEventArgs());
        }
    }

    public void Start()
    {
        var win = _rnd.Next(10, 100);
        WinNumber = win;
        Number = 0;
        Count = 0;

        _started = true;

        onGameStarted(new StartedEventArgs(WinNumber));
    }

    private void onGameStarted(StartedEventArgs e) => _onStarted?.Invoke(this, e);

    private void onGameWin(WinEventArgs e) => _onWin?.Invoke(this, e);
}