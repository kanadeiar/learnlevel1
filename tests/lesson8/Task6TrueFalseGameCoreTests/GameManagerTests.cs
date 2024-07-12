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
        GameManager.serializer = mock.Object;

        var target = new GameManager(fileName);

        var actuals = target.allQuestions;
        actuals.Should().BeEquivalentTo(expected);
        mock.Verify(x => x.OpenAndDeserialize(fileName), Times.Once);
    }

    [Theory, AutoMoqData]
    public void TestNotify([Frozen] Mock<IFormObserver> mock, GameManager manager)
    {
        IFormObservable observable = manager;
        observable.AddObserver(mock.Object);

        manager.QuestionMessage = "Test";

        mock.Verify(x => x.Update(manager, It.IsAny<object>()), Times.Once);
    }



}