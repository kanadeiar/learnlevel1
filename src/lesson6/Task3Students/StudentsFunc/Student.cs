namespace Task3Students.StudentsFunc;

public class Student(
    string lastName,
    string firstName,
    string university,
    string faculty,
    int course,
    string department,
    int group,
    string city,
    int age)
{
    private readonly string _lastName = lastName;
    private readonly string _firstName = firstName;
    private readonly string _university = university;
    private readonly string _faculty = faculty;
    private readonly int _course = course;
    private readonly string _department = department;
    private readonly int _group = group;
    private readonly string _city = city;
    private readonly int _age = age;

    public int Course => _course;

    public int Age => _age;

    public static implicit operator Student(string line)
    {
        var ss = line.Split(';');
        return new Student(ss[0], ss[1], ss[2], ss[3], int.Parse(ss[4]), ss[5], int.Parse(ss[6]), ss[7],
            int.Parse(ss[8]));
    }

    public static implicit operator string(Student student) 
        => string.Join(";", student._lastName, student._firstName, student._university, student._faculty, student._course, student._department, student._group, student._city, student._age);

    public override bool Equals(object? obj)
    {
        var other = obj as Student;
        if (other == null) return false;

        return equals(other);
    }

    private bool equals(Student other)
    {
        return _lastName == other._lastName && _firstName == other._firstName && _university == other._university && _faculty == other._faculty && _course == other._course && _department == other._department && _group == other._group && _city == other._city && _age == other._age;
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(_lastName);
        hashCode.Add(_firstName);
        hashCode.Add(_university);
        hashCode.Add(_faculty);
        hashCode.Add(_course);
        hashCode.Add(_department);
        hashCode.Add(_group);
        hashCode.Add(_city);
        hashCode.Add(_age);
        return hashCode.ToHashCode();
    }

    public override string ToString() 
        => $"{_firstName,-8} {_lastName,-8} {_age,5} лет курс: {_course,-2} группа: {_group,-2} отдел: {_department,-8} город: {_city,-8} ун-т: {_university,8} фак-т: {_faculty,8}";
}