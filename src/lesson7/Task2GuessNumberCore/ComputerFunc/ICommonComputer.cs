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
    int TryingCount { get; }
}

/// <summary>
/// Играющий компьютер
/// </summary>
public interface IGameingComputer
{
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