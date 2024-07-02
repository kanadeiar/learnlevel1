using AutoFixture.Xunit2;
using FluentAssertions;
using Kanadeiar.Tests;
using Moq;
using Task3GameEditorCore.BelieveOrNotBelieveFunc;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Abstractions;
using Task3GameEditorCore.BelieveOrNotBelieveFunc.Base;
using Task3GameEditorCoreTests.BelieveOrNotBelieveFunc.Base;

namespace Task3GameEditorCoreTests.BelieveOrNotBelieveFunc;

public class TrueFalseTests
{
    [Theory, AutoData]
    public void TestFileName(string expected)
    {
        ITrueFalse target = new TrueFalseFake(expected);

        var fake = (TrueFalseFake)target;
        fake.FileName.Should().Be(expected);
    }

    [Theory, AutoData]
    public void TestFileName_WhenSet(string expected)
    {
        ITrueFalse target = new TrueFalseFake(string.Empty);
        var fake = (TrueFalseFake)target;
        fake.FileName = expected;

        fake.FileName.Should().Be(expected);
    }

    [Theory]
    [AutoData]
    public void TestAdd(Question[] expected, string fileName)
    {
        ITrueFalse target = new TrueFalse(fileName);

        Array.ForEach(expected, q => target.Add(q.Text, q.IsTrue));

        target.Count.Should().Be(expected.Length);
        target[0].Should().BeEquivalentTo(expected[0]);
        target[2].Should().BeEquivalentTo(expected[2]);
    }

    [Theory]
    [AutoData]
    public void TestRemove(Question[] expected, string fileName)
    {
        ITrueFalse target = new TrueFalse(fileName);
        Array.ForEach(expected, q => target.Add(q.Text, q.IsTrue));

        target.Remove(0);

        target.Count.Should().Be(expected.Length - 1);
        target[0].Should().BeEquivalentTo(expected[1]);
    }

    [Theory]
    [AutoData]
    public void TestRemove_WhenIncorrect(Question[] expected, string fileName)
    {
        ITrueFalse target = new TrueFalse(fileName);
        Array.ForEach(expected, q => target.Add(q.Text, q.IsTrue));

        target.Remove(-1);
        target.Remove(99);

        target.Count.Should().Be(expected.Length);
    }

    [Theory]
    [InlineAutoMoqData("test", true)]
    [InlineAutoMoqData("Вопрос", true)]
    public void TestSave(string text, bool isTrue, [Frozen] Mock<IXmlFileSerializer<List<Question>>> serMock, string fileName)
    {
        ITrueFalse target = new TrueFalseFake(fileName, serMock.Object);
        target.Add(text, isTrue);

        target.Save();

        var fake = (TrueFalseFake)target;
        serMock.Verify(x => x.SerializeAndSave(fake.Questions.ToList(), fileName), Times.Once);
    }

    [Theory]
    [InlineAutoMoqData("test", true)]
    [InlineAutoMoqData("Вопрос", true)]
    public void TestLoad(string text, bool isTrue, [Frozen] Mock<IXmlFileSerializer<List<Question>>> serMock, string fileName)
    {
        ITrueFalse target = new TrueFalseFake(fileName, serMock.Object);
        serMock.Setup(x => x.OpenAndDeserialize(fileName)).Returns(new[] { new Question(text, isTrue) }.ToList);

        target.Load();

        serMock.Verify(x => x.OpenAndDeserialize(fileName), Times.Once);
        target[0].Text = text;
        target[0].IsTrue = isTrue;
    }
}