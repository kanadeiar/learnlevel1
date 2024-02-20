namespace Task5TwoDimensionalArrayClassTests.DoubleArrayFunc.TestBase;

public class DoubleArrayFake : DoubleArray
{
    public DoubleArrayFake(int[,] numbers, IFile file) : base(numbers)
    {
        File = file;
    }
}