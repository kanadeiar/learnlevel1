namespace Task2GuessNumberCore.ComputerFunc.Core;

internal class ComputerCore
{
    internal EventHandler<WonEventArgs>? onWon;
    internal EventHandler<NotGuessedEventArgs>? onNotGuessed;

    private Random _rnd = new();
    private int _computerNumber;

    public void GenerateNewNumber()
    {
        _computerNumber = _rnd.Next(1, 100);
    }

    public void CheckNumber(int number)
    {
        if (number == _computerNumber)
        {
            onGameWon(new WonEventArgs());
        }
        else
        {
            var code = number < _computerNumber
                ? NotGuessedCode.IsLess
                : NotGuessedCode.IsGreater;
            onTryNotGuessed(new NotGuessedEventArgs(code));
        }
    }

    private void onGameWon(WonEventArgs e) => onWon?.Invoke(this, e);
    private void onTryNotGuessed(NotGuessedEventArgs e) => onNotGuessed?.Invoke(this, e);

    public int ComputerNumber => _computerNumber;
}