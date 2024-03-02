namespace Task3Students.StudentsFunc;

public record Student
{
    private string _lastName;
    private string _firstName;
    private string _university;
    private string _faculty;
    private int _course;
    private string _department;
    private int _group;
    private string _city;
    private int _age;

    public Student(string lastName, string firstName, string university, string faculty, int course, string department, int group, string city, int age)
    {
        _lastName = lastName;
        _firstName = firstName;
        _university = university;
        _faculty = faculty;
        _course = course;
        _department = department;
        _group = group;
        _city = city;
        _age = age;
    }

    public string Join() 
        => string.Join(";", _lastName, _firstName, _university, _faculty, _course, _department, _group, _city, _age);

    public override string ToString() 
        => $"{_firstName,-8} {_lastName,-8} {_age,5} лет курс: {_course,-2} группа: {_group,-2} отдел: {_department,-8} город: {_city,-8} ун-т: {_university,8} фак-т: {_faculty,8}";
}