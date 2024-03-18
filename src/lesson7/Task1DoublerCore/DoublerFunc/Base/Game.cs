namespace Task1DoublerCore.DoublerFunc.Base;

internal class Game(IValueingDoubler doubler)
{
    internal EventHandler<StartedEventArgs>? onStarted;
    internal EventHandler<WinEventArgs>? onWin;

    private Random _rnd = new();
    private bool _started;

    internal void startGame()
    {
        doubler.WinNumber = _rnd.Next(10, 100);
        _started = true;

        onGameStarted(new StartedEventArgs(doubler.WinNumber));
    }

    internal void checkWinGame(bool isNumbersEqualWin)
    {
        var isWinInGame = _started && isNumbersEqualWin;
        if (isWinInGame)
        {
            _started = false;
            onGameWin(new WinEventArgs());
        }
    }

    private void onGameStarted(StartedEventArgs e) => onStarted?.Invoke(this, e);

    private void onGameWin(WinEventArgs e) => onWin?.Invoke(this, e);
}