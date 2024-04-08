namespace Task2GuessNumberCore.ComputerFunc.Base;

public class NotGuessedEventArgs(NotGuessedCode code) : EventArgs
{
    public NotGuessedCode Code => code;
}