namespace Task3Students.StudentsFunc;

public class Students : ICommonStudents
{
    private readonly IEnumerable<Student> _items;

    public (int bak, int mag) CountOfLevels
    {
        get
        {
            var bak = _items.Count(x => x.Course <= 4);
            var mag = _items.Count(x => x.Course >= 5);
            return (bak, mag);
        }
    }

    public (int five, int six) CountOfFiveSix
    {
        get
        {
            var five = _items.Count(x => x.Course == 5);
            var six = _items.Count(x => x.Course == 6);
            return (five, six);
        }
    }
    
    public static StudentsFactory Factory = new();

    public Students(IEnumerable<Student> items)
    {
        _items = items;
    }

    public IDictionary<int, int> CoursesFrequency(Predicate<Student> predicate)
    {
        var result = _items
            .Where(predicate.Invoke)
            .GroupBy(x => x.Course)
            .ToDictionary(x => x.Key, x => x.Count());
        return result;
    }

    public ICommonStudents AgesSort()
    {
        var results = _items.OrderBy(x => x.Age);
        return new Students(results);
    }

    public ICommonStudents CoursesAgesSort()
    {
        var results = _items
            .OrderBy(x => x.Course)
            .ThenBy(x => x.Age);
        return new Students(results);
    }

    public IEnumerator<Student> GetEnumerator() => _items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}