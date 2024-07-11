using AutoFixture.Xunit2;
using FluentAssertions;
using Kanadeiar.Desktop.Forms;
using Kanadeiar.Tests;
using Moq;
using Task5CSVToXMLApp.ConverterModule;
using Task5CSVToXMLApp.ConverterModule.Abstractions;

namespace Task5CSVToXMLAppTests.ConverterModule;

public class ConverterProgramTests
{
    [Theory(DisplayName = "Проверка подписки на события"), AutoMoqData]
    public void TestNotify([Frozen] Mock<IFormObserver> mock, ConverterProgram program)
    {
        IFormObservable observable = program;
        observable.AddObserver(mock.Object);

        program.Data = new List<string>();

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }

    [Theory(DisplayName = "Проверка загрузки данных из файла")]
    [InlineAutoMoqData("Петров;Петр;ПГУ;Мехмат;1;Математический;1;Москва;18",
        "Иванов;Иван;МГУ;Физика;2;Филологический;2;Пенза;22",
        "Степанова;Софья;УлГУ;Философия;1;Математический;2;Ульяновск;19")]
    public void TestLoad(string data0, string data1, string data2, [Frozen] Mock<IStreamReader> mock)
    {
        mock.SetupSequence(x => x.EndOfStream)
            .Returns(false).Returns(false).Returns(false)
            .Returns(true);
        mock.SetupSequence(x => x.ReadLine())
            .Returns(data0).Returns(data1).Returns(data2);
        var program = new ConverterProgram();
        program.converter.streamReader = mock.Object;

        program.Load("test.csv");

        var studs = program.students;
        var actuals = studs.ToArray();
        actuals.Length.Should().Be(3);
        actuals.First().FirstName.Should().Be("Петров");
        actuals.First().Age.Should().Be(18);
        actuals.Last().FirstName.Should().Be("Степанова");
        actuals.Last().Age.Should().Be(19);
        program.Data.First().Should().Be("Петров Петр ПГУ Мехмат Математический 18 1 1 Москва");
        program.Data.Last().Should().Be("Степанова Софья УлГУ Философия Математический 19 1 2 Ульяновск");
    }

    [Theory(DisplayName = "Проверка сохранения данных в файле")]
    [AutoMoqData]
    public void TestSave(List<Student> students, [Frozen] Mock<IXmlFileSerializer<List<Student>>> mock)
    {
        var program = new ConverterProgram();
        program.converter.xmlSerializer = mock.Object;
        program.students = new Students(students);

        program.Save("test.xml");

        mock.Verify(x => x.SerializeAndSave(students, "test.xml"), Times.Once);
    }
}