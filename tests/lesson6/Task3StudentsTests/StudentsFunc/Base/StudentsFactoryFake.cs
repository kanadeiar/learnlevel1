namespace Task3StudentsTests.StudentsFunc.Base;

public class StudentsFactoryFake : StudentsFactory
{
    public static StudentsFactory Create(IFile file)
    {
        return new StudentsFactoryFake { File = file };
    }
}