using System.Collections;

namespace Task5CSVToXMLApp.ConverterModule;

public class Students : IEnumerable<Student>
{
    private List<Student> _students;

    public Students(List<Student>? students)
    {
        _students = students ?? new List<Student>();
    }

    public IEnumerator<Student> GetEnumerator() => _students.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _students.GetEnumerator();
}