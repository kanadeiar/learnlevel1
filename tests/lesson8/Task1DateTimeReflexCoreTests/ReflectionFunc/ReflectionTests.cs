namespace Task1DateTimeReflexCoreTests.ReflectionFunc;

public class ReflectionTests
{
    [Theory, AutoMoqData]
    public void TestNotify(Mock<IFormObserver> mock)
    {
        var reflection = new Reflection();
        IFormObservable observable = reflection;
        observable.AddObserver(mock.Object);

        reflection.ReflectionResult = "test";

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }
}