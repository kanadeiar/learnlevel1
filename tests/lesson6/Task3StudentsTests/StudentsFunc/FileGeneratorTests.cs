namespace Task3StudentsTests.StudentsFunc;

public class FileGeneratorTests
{
    [Theory, AutoMoqData]
    public void TestGenerateCsvFile([Frozen] Mock<IFile> mock)
    {
        var actuals = Array.Empty<string>();
        mock.Setup(x => x.WriteAllLines("test.txt", It.IsAny<string[]>()))
            .Callback((string _, string[] strs) => { actuals = strs; });
        var generator = FileGeneratorFake.Create(mock.Object);

        generator.GenerateCsvFile("test.txt");

        mock.Verify(x => x.WriteAllLines("test.txt", It.IsAny<string[]>()), Times.Once);
        actuals.Should().HaveCount(15);
    }
}