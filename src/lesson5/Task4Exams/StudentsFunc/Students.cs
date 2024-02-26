namespace Task4Exams.StudentsFunc;

public class Students : ICommonStudents
{
    private ICommonStudent[] _lines;

    public Students(IEnumerable<ICommonStudent> lines)
    {
        _lines = lines.ToArray();
    }

    public static StudentsFactory Factory = new();

    public IEnumerator<Student> GetEnumerator() 
        => _lines.Cast<Student>().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() 
        => GetEnumerator();
}