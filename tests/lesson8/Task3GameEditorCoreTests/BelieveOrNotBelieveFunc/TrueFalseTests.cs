using AutoFixture.Xunit2;
using FluentAssertions;
using Kanadeiar.Tests;
using Moq;
using Task3GameEditorCore.BelieveOrNotBelieveFunc;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Adapters;
using Task3GameEditorCoreTests.BelieveOrNotBelieveFunc.Base;

namespace Task3GameEditorCoreTests.BelieveOrNotBelieveFunc;

public class TrueFalseTests
{
    [Theory, AutoData]
    public void TestFileName(string expected)
    {
        var target = new TrueFalse(expected);

        target.FileName.Should().Be(expected);
    }

    [Theory, AutoData]
    public void TestFileName_WhenSet(string expected)
    {
        var target = new TrueFalse(string.Empty);
        target.FileName = expected;

        target.FileName.Should().Be(expected);
    }

    [Theory]
    [AutoData]
    public void TestAdd(Question[] expected, string fileName)
    {
        var target = new TrueFalse(fileName);

        Array.ForEach(expected, q => target.Add(q.Text, q.IsTrue));

        target.Count.Should().Be(expected.Length);
        target[0].Should().BeEquivalentTo(expected[0]);
        target[2].Should().BeEquivalentTo(expected[2]);
    }

    [Theory]
    [AutoData]
    public void TestRemove(Question[] expected, string fileName)
    {
        var target = new TrueFalse(fileName);
        Array.ForEach(expected, q => target.Add(q.Text, q.IsTrue));

        target.Remove(0);

        target.Count.Should().Be(expected.Length - 1);
        target[0].Should().BeEquivalentTo(expected[1]);
    }

    [Theory]
    [AutoData]
    public void TestRemove_WhenIncorrect(Question[] expected, string fileName)
    {
        var target = new TrueFalse(fileName);
        Array.ForEach(expected, q => target.Add(q.Text, q.IsTrue));

        target.Remove(-1);
        target.Remove(99);

        target.Count.Should().Be(expected.Length);
    }

    [Theory]
    [InlineAutoMoqData("test", true)]
    [InlineAutoMoqData("Вопрос", true)]
    public void TestSave(string text, bool isTrue, [Frozen]Mock<IXmlSerializer> serMock, string fileName)
    {
        var streamMock = new Mock<IFileStream>();
        var target = new TrueFalseFake(fileName, serMock.Object, streamMock.Object);
        target.Add(text, isTrue);

        target.Save();

        serMock.Verify(x => x.Serialize(streamMock.Object, target.Questions), Times.Once);
    }

    [Theory]
    [InlineAutoMoqData("test", true)]
    [InlineAutoMoqData("Вопрос", true)]
    public void TestLoad(string text, bool isTrue, [Frozen] Mock<IXmlSerializer> serMock, string fileName)
    {
        var streamMock = new Mock<IFileStream>();
        var target = new TrueFalseFake(fileName, serMock.Object, readFileStream: streamMock.Object);
        serMock.Setup(x => x.Deserialize(streamMock.Object)).Returns(new[]{ new Question(text, isTrue) }.ToList);

        target.Load();

        serMock.Verify(x => x.Deserialize(streamMock.Object), Times.Once);
        target[0].Text = text;
        target[0].IsTrue = isTrue;
    }
}