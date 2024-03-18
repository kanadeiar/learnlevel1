namespace Task1DoublerCore.DoublerFunc.Base;

public class StartedEventArgs(int winNumber) : EventArgs
{
    public int WinNumber => winNumber;
}