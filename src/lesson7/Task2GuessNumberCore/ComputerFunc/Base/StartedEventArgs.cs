namespace Task2GuessNumberCore.ComputerFunc.Base;

public class StartedEventArgs(int tryingCount) : EventArgs
{
    public int TryingCount => tryingCount;
}