namespace Task4ExamsTests.StudentsFunc.Base;

public class FileGeneratorFake : FileGenerator
{
    public FileGeneratorFake(IFile file)
    {
        File = file;
    }
}