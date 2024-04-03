namespace Task1DoublerCore.DoublerFunc.Base;

internal class Game(IValueingDoubler doubler)
{
    internal EventHandler<StartedEventArgs>? onStarted;
    internal EventHandler<WonEventArgs>? onWon;

    private Random _rnd = new();
    private bool _isStarted;

    internal void startGame()
    {
        doubler.WinNumber = _rnd.Next(10, 100);
        _isStarted = true;

        onGameStarted(new StartedEventArgs(doubler.WinNumber));
    }

    internal void checkWinGame(bool isNumbersEqualWin)
    {
        var isWinInGame = _isStarted && isNumbersEqualWin;
        if (isWinInGame)
        {
            _isStarted = false;
            onGameWon(new WonEventArgs());
        }
    }

    private void onGameStarted(StartedEventArgs e) => onStarted?.Invoke(this, e);

    private void onGameWon(WonEventArgs e) => onWon?.Invoke(this, e);
}