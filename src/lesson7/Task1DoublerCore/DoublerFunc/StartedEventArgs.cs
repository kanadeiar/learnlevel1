namespace Task1DoublerCore.DoublerFunc;

public class StartedEventArgs(int winNumber) : EventArgs
{
    public int WinNumber => winNumber;
}