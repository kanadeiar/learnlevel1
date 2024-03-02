namespace Task3StudentsTests.StudentsFunc.Base;

public class FileGeneratorFake : FileGenerator
{
    public static IGeneratingFileGenerator Create(IFile file)
    {
        return new FileGeneratorFake { File = file };
    }
}