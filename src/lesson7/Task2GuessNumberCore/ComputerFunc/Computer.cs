namespace Task2GuessNumberCore.ComputerFunc;

public class Computer : ModelBase, ICommonComputer
{
    public event EventHandler<StartedEventArgs>? OnStarted
    {
        add => _game.onStarted += value;
        remove => _game.onStarted -= value;
    }
    
    public event EventHandler<WonEventArgs>? OnWon
    {
        add => _core.onWon += value;
        remove => _core.onWon -= value;
    }
    
    public event EventHandler<NotGuessedEventArgs>? OnNotGuessed
    {
        add => _core.onNotGuessed += value;
        remove => _core.onNotGuessed -= value;
    }
    
    public event EventHandler<GameOverEventArgs>? OnGameOver
    {
        add => _game.onGameOver += value;
        remove => _game.onGameOver -= value;
    }

    /// <summary>
    /// Максимально допустимое число попыток угадать число
    /// </summary>
    public const int TRYING_COUNT = 3;

    private readonly Game _game;
    private readonly ComputerCore _core;
    
    private int _tryingCount;

    public int TryingCount
    {
        get => _tryingCount;
        set => Set(ref _tryingCount, value);
    }
    
    public Computer()
    {
        _game = new Game(this);
        _core = new ComputerCore();
    }

    public void Start()
    {
        _core.GenerateNewNumber();
        _game.InitGame();
    }

    public void TryNumber(int number)
    {
        _game.CheckFinish();
        _core.CheckNumber(number);
    }
    
    protected int ComputerNumber => _core.ComputerNumber;
}