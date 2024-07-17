namespace Task6TrueFalseGameCore.GameModule.StateFunction;

internal class GameStateGameOver : GameState
{
    public override string QuestionText =>
        $"Вы проиграли игру!\nВы правильно ответили только на {Context.countTrueAnswers} вопроса из {Game.SIZE_QUESTION}";
}