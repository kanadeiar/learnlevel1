namespace Task3BestArrayClassTests.BestArrayFunc.TestBase;

public class BestArrayFactoryFake : BestArrayFactory
{
    public BestArrayFactoryFake(IFile file)
    {
        File = file;
    }
}