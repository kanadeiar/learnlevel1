namespace Task4ExamsTests.StudentsFunc;

public class FileGeneratorTests
{
    [Theory, AutoMoqData]
    public void TestGenerateDataFile([Frozen] Mock<IFile> mock)
    {
        var actuals = Array.Empty<string>();
        mock.Setup(x => x.WriteAllLines("test.txt", It.IsAny<string[]>()))
            .Callback((string _, string[] strs) => { actuals = strs; });
        var generator = new FileGeneratorFake(mock.Object);

        generator.GenerateDataFile("test.txt");

        mock.Verify(x => x.WriteAllLines("test.txt", It.IsAny<string[]>()), Times.Once);
        actuals.Should().HaveCount(30);
    }
}