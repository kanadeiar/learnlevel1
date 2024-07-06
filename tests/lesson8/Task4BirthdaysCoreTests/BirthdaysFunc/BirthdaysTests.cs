using System.Collections;
using AutoFixture.Xunit2;
using FluentAssertions;
using Moq;
using Task4BirthdaysCore.BirthdaysFunc;
using Task4BirthdaysCore.BirthdaysFunc.Abstractions;
using Task4BirthdaysCore.BirthdaysFunc.Base;

namespace Task4BirthdaysCoreTests.BirthdaysFunc;

public class BirthdaysTests
{
    [Theory, AutoData]
    public void TestFileName(string expectedFileName)
    {
        var target = new Birthdays(expectedFileName);

        target.fileName.Should().Be(expectedFileName);
    }

    [Theory, AutoData]
    public void TestFileName_WhenSetValue(string expected)
    {
        var target = new Birthdays(string.Empty);
        target.fileName = expected;

        target.fileName.Should().Be(expected);
    }

    [Theory, AutoData]
    public void TestEnumerable(Birthday[] expected, string fileName)
    {
        IEnumerableBirthdays enumerable = new Birthdays(fileName);
        ((Birthdays)enumerable).data = new BirthdaysData(expected.ToList());

        var list = new List<Birthday>();
        foreach (Birthday each in (IEnumerable)enumerable)
        {
            each.Deconstruct(out var surname, out var name, out var birth);
            list.Add(new Birthday(surname, name, birth));
        }

        list.Count.Should().Be(expected.Length);
        list.First().Should().BeEquivalentTo(expected.First());
        list.Last().Should().BeEquivalentTo(expected.Last());
    }

    [Theory, AutoData]
    public void TestAdd(Birthday[] expected, string fileName)
    {
        IEditingBirthdays editing = new Birthdays(fileName);
        
        Array.ForEach(expected, x => editing.Add(x));

        var birthdays = editing as Birthdays;
        birthdays.Count().Should().Be(expected.Length);
        birthdays.First().Should().BeEquivalentTo(expected.First());
        birthdays.Last().Should().BeEquivalentTo(expected.Last());
    }

    [Theory, AutoData]
    public void TestRemove(Birthday[] expected, string fileName)
    {
        IEditingBirthdays editing = new Birthdays(fileName);
        var birthdays = editing as Birthdays;
        birthdays.data = new BirthdaysData(expected.ToList());

        editing.Remove(expected.First());

        birthdays.Count().Should().Be(expected.Length - 1);
        birthdays.First().Should().BeEquivalentTo(expected.Skip(1).First());
        birthdays.Last().Should().BeEquivalentTo(expected.Last());
    }

    [Theory, AutoData]
    public void TestSave(Birthday[] expected, [Frozen] Mock<IXmlFileSerializer<List<Birthday>>> serMock, string fileName)
    {
        var target = new Birthdays(fileName);
        target.data = new BirthdaysData(expected.ToList());
        target.serializer = serMock.Object;

        target.Save();

        serMock.Verify(x => x.SerializeAndSave(expected.ToList(), fileName), Times.Once);
    }

    [Theory, AutoData]
    public void TestLoad(Birthday[] expected, [Frozen] Mock<IXmlFileSerializer<List<Birthday>>> serMock, string fileName)
    {
        var target = new Birthdays(fileName);
        serMock.Setup(x => x.OpenAndDeserialize(fileName))
            .Returns(expected.ToList);
        target.serializer = serMock.Object;

        target.Load();

        serMock.Verify(x => x.OpenAndDeserialize(fileName), Times.Once);
        target.First().Should().BeEquivalentTo(expected.First());
    }
}