using AutoFixture.Xunit2;
using FluentAssertions;
using Kanadeiar.Desktop.Forms;
using Kanadeiar.Tests;
using Moq;
using Task6TrueFalseGameCore.GameModule;
using Task6TrueFalseGameCore.GameModule.Abstractions;

namespace Task6TrueFalseGameCoreTests;

public class GameManagerTests
{
    [Theory]
    [AutoMoqData]
    public void TestConstructor(Question[] expected, [Frozen] Mock<IXmlFileSerializer<List<Question>>> mock, string fileName)
    {
        mock.Setup(x => x.OpenAndDeserialize(fileName))
            .Returns(expected.ToList);
        QuestionLoader.serializer = mock.Object;

        var target = new GameManager(fileName);

        var actuals = target.game.allQuestions;
        actuals.Should().BeEquivalentTo(expected);
        mock.Verify(x => x.OpenAndDeserialize(fileName), Times.Once);
        target.QuestionText.Should().Contain("Добро пожаловать в игру!");
        target.EnableStart.Should().BeTrue();
        target.EnableAnswer.Should().BeFalse();
    }

    [Theory]
    [AutoMoqData]
    public void TestNotify([Frozen] Mock<IFormObserver> mock, GameManager manager)
    {
        IFormObservable observable = manager;
        observable.AddObserver(mock.Object);

        manager.NotifyObservers();

        mock.Verify(x => x.Update(manager, It.IsAny<object>()), Times.Once);
    }

    [Theory]
    [AutoMoqData]
    public void TestStart(Question[] questions, GameManager manager)
    {
        manager.game.allQuestions = questions.ToList();

        manager.Start();

        manager.QuestionText.Should().Be(questions[manager.game.generedQuestions[0]].Text);
        manager.EnableStart.Should().BeFalse();
        manager.EnableAnswer.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void TestYes_WhenYesAnswer(GameManager manager)
    {
        var questions = new Question[]
        {
            new() { Text = "Тест1", IsTrue = true },
            new() { Text = "Тест2", IsTrue = true },
            new() { Text = "Тест3", IsTrue = true },
        };
        manager.game.allQuestions = questions.ToList();
        manager.Start();
        manager.game.generedQuestions = [0, 1, 2];

        manager.Yes();

        manager.QuestionText.Should().Be(questions[manager.game.generedQuestions[1]].Text);
    }

    [Theory]
    [AutoMoqData]
    public void TestNo_WhenNoAnswer(GameManager manager)
    {
        var questions = new Question[]
        {
            new() { Text = "ЛожныйТест1", IsTrue = false },
            new() { Text = "ЛожныйТест2", IsTrue = false },
            new() { Text = "ЛожныйТест3", IsTrue = false },
        };
        manager.game.allQuestions = questions.ToList();
        manager.Start();
        manager.game.generedQuestions = [0, 1, 2];

        manager.No();

        manager.QuestionText.Should().Be(questions[manager.game.generedQuestions[1]].Text);
    }

    [Theory]
    [AutoMoqData]
    public void TestAnswers_WhenGoodGame_ThenVictory(GameManager manager)
    {
        var questions = new Question[]
        {
            new() { Text = "Тест1", IsTrue = true },
            new() { Text = "Тест2", IsTrue = false },
            new() { Text = "Тест3", IsTrue = false },
        };
        manager.game.allQuestions = questions.ToList();
        manager.Start();
        manager.game.generedQuestions = [0, 1, 2];

        manager.Yes();
        manager.No();
        manager.No();

        manager.QuestionText.Should().Contain("Вы выиграли игру!");
        manager.EnableStart.Should().BeTrue();
        manager.EnableAnswer.Should().BeFalse();
    }

    [Theory]
    [AutoMoqData]
    public void TestAnswers_WhenBadGame_ThenGameOver(GameManager manager)
    {
        var questions = new Question[]
        {
            new() { Text = "Тест1", IsTrue = false },
            new() { Text = "Тест2", IsTrue = false },
            new() { Text = "Тест3", IsTrue = true },
        };
        manager.game.allQuestions = questions.ToList();
        manager.Start();
        manager.game.generedQuestions = [0, 1, 2];

        manager.Yes();
        manager.No();
        manager.Yes();

        manager.QuestionText.Should().Contain("Вы проиграли игру!");
    }
}