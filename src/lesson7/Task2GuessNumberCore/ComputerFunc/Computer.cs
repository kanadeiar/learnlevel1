namespace Task2GuessNumberCore.ComputerFunc;

public class Computer : ModelBase, ICommonComputer
{
    private int _computerNumber;

    public int ComputerNumber 
    { 
        get => _computerNumber; 
        set => Set(ref _computerNumber, value);
    }

    private int _tryingCount;

    public int TryingCount
    {
        get => _tryingCount;
        set => Set(ref _tryingCount, value);
    }

    public Computer()
    {
        
    }
}