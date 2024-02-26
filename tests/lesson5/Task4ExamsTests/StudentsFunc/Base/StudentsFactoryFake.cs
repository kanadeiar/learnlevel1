namespace Task4ExamsTests.StudentsFunc.Base;

public class StudentsFactoryFake : StudentsFactory
{
    public StudentsFactoryFake(IFile file)
    {
        File = file;
    }
}