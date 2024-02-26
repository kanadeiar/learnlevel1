namespace Task4Exams.StudentsFunc;

public class Student : ICommonStudent
{
    private readonly string _surname;
    private readonly string _name;
    private readonly int[] _valuations;

    public double Average => (double)_valuations.Sum() / _valuations.Length;

    public Student(string surname, string name, int[] valuations)
    {
        _surname = surname;
        _name = name;
        _valuations = valuations;
    }

    public override string ToString()
    {
        return $"{_surname} {_name} - {Average.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}