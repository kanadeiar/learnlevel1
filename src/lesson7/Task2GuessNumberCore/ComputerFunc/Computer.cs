using Task2GuessNumberCore.ComputerFunc.Base;

namespace Task2GuessNumberCore.ComputerFunc;

public class Computer : ModelBase, ICommonComputer
{
    private EventHandler<StartedEventArgs>? _onStarted;

    public event EventHandler<StartedEventArgs>? OnStarted
    {
        add => _onStarted += value;
        remove => _onStarted -= value;
    }

    private EventHandler<WonEventArgs>? _onWon;

    public event EventHandler<WonEventArgs>? OnWon
    {
        add => _onWon += value;
        remove => _onWon -= value;
    }

    public const int TRYING_COUNT = 7;

    private Random _rnd = new();
    private bool _isStarted;

    private int _computerNumber;
    
    private int _tryingCount;

    public int TryingCount
    {
        get => _tryingCount;
        protected set => Set(ref _tryingCount, value);
    }

    public Computer()
    {
        
    }

    public void Start()
    {
        _computerNumber = _rnd.Next(1, 100);
        _isStarted = true;
        TryingCount = TRYING_COUNT;

        onGameStarted(new StartedEventArgs(_tryingCount));
    }

    public void TryNumber(int number)
    {
        if (_isStarted == false) return;
        TryingCount++;
        if (number == _computerNumber)
        {
            onGameWon(new WonEventArgs());
        }
    }

    private void onGameStarted(StartedEventArgs e) => _onStarted?.Invoke(this, e);

    private void onGameWon(WonEventArgs e) => _onWon?.Invoke(this, e);

    protected int ComputerNumber => _computerNumber;
}