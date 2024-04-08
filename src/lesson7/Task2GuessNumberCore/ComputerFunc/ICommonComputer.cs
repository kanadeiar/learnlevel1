namespace Task2GuessNumberCore.ComputerFunc;

/// <summary>
/// Общий компьютер
/// </summary>
public interface ICommonComputer : IValueingComputer, IGameingComputer, IFormObservable
{
}

/// <summary>
/// Содержащий значения компьютер
/// </summary>
public interface IValueingComputer
{
    /// <summary>
    /// Количество оставшихся попыток
    /// </summary>
    int TryingCount { get; set; }
}

/// <summary>
/// Играющий компьютер
/// </summary>
public interface IGameingComputer
{
    /// <summary>
    /// Событие после запуска игры
    /// </summary>
    event EventHandler<StartedEventArgs>? OnStarted;

    /// <summary>
    /// Событие при выигрыше в игре
    /// </summary>
    event EventHandler<WonEventArgs>? OnWon;

    /// <summary>
    /// Событие при неудачной попытке угадать число
    /// </summary>
    event EventHandler<NotGuessedEventArgs>? OnNotGuessed;

    /// <summary>
    /// Начать игру
    /// </summary>
    void Start();

    /// <summary>
    /// Попытка угадать число
    /// </summary>
    /// <param name="number">Предполагаемое число</param>
    void TryNumber(int number);
}