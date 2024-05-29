namespace Task2GuessNumberCore.ComputerFunc.Base;

public class NotGuessedEventArgs(NotGuessedCode code, int number) : EventArgs
{
    public NotGuessedCode Code => code;
    public int Number => number;
}