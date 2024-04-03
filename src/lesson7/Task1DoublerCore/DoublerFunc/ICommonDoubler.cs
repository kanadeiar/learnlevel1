namespace Task1DoublerCore.DoublerFunc;

/// <summary>
/// Общий удвоитель
/// </summary>
public interface ICommonDoubler : IValueingDoubler, IControllingDoubler, IGameingDoubler, IFormObservable
{
}

/// <summary>
/// Удвоитель, содержащий значения
/// </summary>
public interface IValueingDoubler
{
    /// <summary>
    /// Текущее число
    /// </summary>
    int Number { get; set; }

    /// <summary>
    /// Количество действий
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// Загаданное число
    /// </summary>
    int WinNumber { get; set; }
}

/// <summary>
/// Управляемый удвоитель
/// </summary>
public interface IControllingDoubler
{
    /// <summary>
    /// Увеличение числа на еденицу
    /// </summary>
    void Increment();

    /// <summary>
    /// Перемножить число на два
    /// </summary>
    void Double();

    /// <summary>
    /// Сбросить число на нуль
    /// </summary>
    void Reset();

    /// <summary>
    /// Отменить последнее действие
    /// </summary>
    void Undo();
}

/// <summary>
/// Игровой удвоитель
/// </summary>
public interface IGameingDoubler
{
    /// <summary>
    /// Игра начата
    /// </summary>
    event EventHandler<StartedEventArgs>? OnStarted;

    /// <summary>
    /// Игра выиграна
    /// </summary>
    event EventHandler<WinEventArgs>? OnWin;
    
    /// <summary>
    /// Начать игру
    /// </summary>
    void Start();
}