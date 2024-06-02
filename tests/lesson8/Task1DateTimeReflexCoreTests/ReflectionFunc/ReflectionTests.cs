using FluentAssertions;

namespace Task1DateTimeReflexCoreTests.ReflectionFunc;

public class ReflectionTests
{
    [Theory, AutoMoqData]
    public void TestNotify(Mock<IFormObserver> mock, Reflection reflection)
    {
        IFormObservable observable = reflection;
        observable.AddObserver(mock.Object);

        reflection.ReflectionResult = "test";

        mock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }

    [Theory]
    [InlineAutoMoqData("DateTime")]
    [InlineAutoMoqData("Int32 Hour")]
    [InlineAutoMoqData("Int32 Day")]
    [InlineAutoMoqData("Int32 Minute")]
    [InlineAutoMoqData("Int32 Month")]
    [InlineAutoMoqData("Int32 Year")]
    [InlineAutoMoqData("Int32 Second")]
    [InlineAutoMoqData("Int64 Ticks")]
    [InlineAutoMoqData("Int32 Millisecond")]
    [InlineAutoMoqData("Int32 Microsecond")]
    [InlineAutoMoqData("Int32 Nanosecond")]
    public void TestExecuteFor_ThenContains(string expected, Reflection reflection)
    {
        ITextingReflection texting = reflection;

        texting.ExecuteFor(typeof(DateTime));

        var actual = texting.ReflectionResult;
        actual.Should().Contain(expected);
    }
}