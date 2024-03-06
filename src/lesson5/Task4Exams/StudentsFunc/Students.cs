namespace Task4Exams.StudentsFunc;

public class Students : ICommonStudents
{
    private ICommonStudent[] _lines;

    public Students(IEnumerable<ICommonStudent> lines)
    {
        _lines = lines.ToArray();
    }

    public static StudentsFactory Factory = new();

    public IEnumerator<ICommonStudent> GetEnumerator() 
        => _lines.Cast<Student>().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() 
        => GetEnumerator();

    public IEnumerable<ICommonStudent> Dummers()
    {
        if (_lines.Any() == false) yield break;

        var dummThreeStudents = _lines.OrderBy(st => st.Average).Take(3);
        var minAverage = dummThreeStudents.Last().Average;
        foreach (var student in _lines.OrderBy(st => st.Average))
        {
            if (student.Average > minAverage) yield break;

            yield return student;
        }
    }
}