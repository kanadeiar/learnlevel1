namespace Task6TrueFalseGameCore.GameModule.StateFunction;

internal class GameStateQuestion : GameState
{
    public override string QuestionText => Context.Current.Text;

    public override bool EnableStart => false;
    public override bool EnableAnswer => true;

    public override void Start() { }

    public override void Yes()
    {
        if (Context.Current.IsTrue)
        {
            Context.countTrueAnswers++;
        }

        answer();
    }

    public override void No()
    {
        if (Context.Current.IsTrue == false)
        {
            Context.countTrueAnswers++;
        }

        answer();
    }

    private void answer()
    {
        Context.currentQuestion++;

        if (Context.currentQuestion > Game.SIZE_QUESTION - 1)
        {
            if (Context.countTrueAnswers == Game.SIZE_QUESTION)
            {
                ToVictory();
            }
            else
            {
                ToGameOver();
            }
        }
    }
}