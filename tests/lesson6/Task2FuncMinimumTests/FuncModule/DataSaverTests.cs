namespace Task2FuncMinimumTests.FuncModule;

public class DataSaverTests
{
    [Theory, AutoMoqData]
    public void TestSaveDataFromFunc(Mock<IBinaryWriter> mock)
    {
        mock.Setup(x => x.Write(It.IsAny<double>()));
        var saver = new DataSaverFake(mock.Object);
        var func = new DataSaver.Func(x => x + 1);

        saver.SaveDataFromFunc(func, "test.txt", 1, 5, 2);

        mock.Verify(x => x.Write(2), Times.Once);
        mock.Verify(x => x.Write(4), Times.Once);
    }

}