namespace Task4Exams.StudentsFunc;

public interface ICommonStudents : IDummersingStudents, IEnumerable<Student>
{

}

public interface IDummersingStudents
{
    IEnumerable<ICommonStudent> Dummers();
}