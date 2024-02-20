namespace Task5TwoDimensionalArrayClassTests.DoubleArrayFunc.TestBase;

public class DoubleArrayFactoryFake : DoubleArrayFactory
{
    public DoubleArrayFactoryFake(IFile file)
    {
        File = file;
    }
}