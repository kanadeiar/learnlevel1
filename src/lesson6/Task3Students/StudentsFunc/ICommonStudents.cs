namespace Task3Students.StudentsFunc;

public interface ICommonStudents : ICountingStudents, ISortingStudents, IEnumerable<Student>
{
}

public interface ICountingStudents
{
    (int five, int six) CountOfFiveSix { get; }
    (int bak, int mag) CountOfLevels { get; }
    IDictionary<int, int> CoursesFrequency(Predicate<Student> predicate);
}

public interface ISortingStudents
{
    ICommonStudents AgesSort();
    ICommonStudents CoursesAgesSort();
}