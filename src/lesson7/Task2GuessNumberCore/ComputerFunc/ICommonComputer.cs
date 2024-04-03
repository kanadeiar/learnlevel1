namespace Task2GuessNumberCore.ComputerFunc;

/// <summary>
/// Общий компьютер
/// </summary>
public interface ICommonComputer : IValueingComputer, IFormObservable
{
}

/// <summary>
/// Содержащий значения компьютер
/// </summary>
public interface IValueingComputer
{
    /// <summary>
    /// Число загаданное компьютером
    /// </summary>
    public int ComputerNumber { get; set; }

    /// <summary>
    /// Количество оставшихся попыток
    /// </summary>
    public int TryingCount { get; set; }
}