﻿namespace Task6TrueFalseGameCore.GameModule;

/// <summary>
/// Режим игры
/// </summary>
public enum GameMode
{
    /// <summary>
    /// Приветствие
    /// </summary>
    Welcome,
    /// <summary>
    /// Задавание вопроса
    /// </summary>
    Question,
    /// <summary>
    /// Игра выиграна
    /// </summary>
    Victory,
    /// <summary>
    /// Игра завершена проигрышом
    /// </summary>
    GameOver
}