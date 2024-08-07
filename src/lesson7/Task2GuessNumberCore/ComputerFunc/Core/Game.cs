﻿namespace Task2GuessNumberCore.ComputerFunc.Core;

internal class Game
{
    internal EventHandler<StartedEventArgs>? onStarted;
    internal EventHandler<GameOverEventArgs>? onGameOver;

    private readonly IValueingComputer _computer;
    private bool _isStarted;

    public Game(IValueingComputer computer)
    {
        _computer = computer;
    }

    public void InitGame()
    {
        _isStarted = true;
        _computer.TryingCount = Computer.TRYING_COUNT;
        onGameStarted(new StartedEventArgs(_computer.TryingCount));
    }

    public bool CheckFinish()
    {
        if (_isStarted == false) return false;
        _computer.TryingCount--;
        if (_computer.TryingCount > 0)
        {
            return true;
        }

        _isStarted = false;
        onGameLost(new GameOverEventArgs());
        return false;
    }

    private void onGameStarted(StartedEventArgs e) => onStarted?.Invoke(this, e);
    private void onGameLost(GameOverEventArgs e) => onGameOver?.Invoke(this, e);
}