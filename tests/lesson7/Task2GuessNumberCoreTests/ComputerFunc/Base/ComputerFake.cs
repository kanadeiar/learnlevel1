namespace Task2GuessNumberCoreTests.ComputerFunc.Base;

public class ComputerFake : Computer
{
    public new int ComputerNumber => base.ComputerNumber;

    public new int TryingCount
    {
        get => base.TryingCount;
        set => base.TryingCount = value;
    }

    public ComputerFake()
    {
        
    }
}