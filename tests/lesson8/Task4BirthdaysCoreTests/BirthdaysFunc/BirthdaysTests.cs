using System.Collections;
using AutoFixture.Xunit2;
using FluentAssertions;
using Kanadeiar.Desktop.Forms;
using Kanadeiar.Tests;
using Moq;
using Task4BirthdaysCore.BirthdaysFunc;
using Task4BirthdaysCore.BirthdaysFunc.Abstractions;
using Task4BirthdaysCore.BirthdaysFunc.Base;

namespace Task4BirthdaysCoreTests.BirthdaysFunc;

public class BirthdaysTests
{
    [Theory, AutoMoqData]
    public void TestNotify([Frozen]Mock<IFormObserver> mock, Birthdays birthdays)
    {
        IFormObservable observable = birthdays;
        observable.AddObserver(mock.Object);

        birthdays.FileName = "test";

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }

    [Theory, AutoData]
    public void TestFileName(string expectedFileName)
    {
        ICommonBirthdays target = new Birthdays(expectedFileName);

        target.FileName.Should().Be(expectedFileName);
    }

    [Theory, AutoData]
    public void TestFileName_WhenSetValue(string expected)
    {
        var target = new Birthdays(string.Empty);
        target.FileName = expected;

        target.FileName.Should().Be(expected);
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

    [Theory, AutoMoqData]
    public void TestSelect([Frozen]Mock<IFormObserver> mock, Birthday[] expected, string fileName)
    {
        ISelectableBirthdays selectable = new Birthdays(fileName);
        IFormObservable observable = (IFormObservable)selectable;
        observable.AddObserver(mock.Object);
        ((Birthdays)selectable).data = new BirthdaysData(expected.ToList());

        selectable.Select(1);

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
        selectable.Selected.Should().BeEquivalentTo(expected.Skip(1).First());
    }

    [Theory]
    [InlineAutoMoqData(-1)]
    [InlineAutoMoqData(3)]
    public void TestSelect_WhenOverRange_ThenNone(int index, [Frozen] Mock<IFormObserver> mock, Birthday[] expected, string fileName)
    {
        ISelectableBirthdays selectable = new Birthdays(fileName);
        IFormObservable observable = (IFormObservable)selectable;
        observable.AddObserver(mock.Object);
        ((Birthdays)selectable).data = new BirthdaysData(expected.ToList());

        selectable.Select(index);

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Never);
    }

    [Theory, AutoData]
    public void TestAdd(Birthday[] expected, string fileName)
    {
        IEditingBirthdays editing = new Birthdays(fileName);
        
        Array.ForEach(expected, x => editing.Add(x));

        var birthdays = (Birthdays)editing;
        birthdays.Count().Should().Be(expected.Length);
        birthdays.First().Should().BeEquivalentTo(expected.First());
        birthdays.Last().Should().BeEquivalentTo(expected.Last());
    }

    [Theory, AutoData]
    public void TestEdit(Birthday[] array, string fileName)
    {
        var expected = new Birthday("New", "Test", new DateTime(1990, 1, 1));
        IEditingBirthdays editing = new Birthdays(fileName);
        var birthdays = (Birthdays)editing;
        birthdays.data = new BirthdaysData(array.ToList());
        
        editing.Edit(1, expected);

        birthdays.Skip(1).First().Should().BeEquivalentTo(expected);
    }

    [Theory, AutoData]
    public void TestRemove(Birthday[] expected, string fileName)
    {
        IEditingBirthdays editing = new Birthdays(fileName);
        var birthdays = (Birthdays)editing;
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