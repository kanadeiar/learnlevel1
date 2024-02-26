namespace Task4Exams.StudentsFunc;

public interface ICommonStudents : IDummersingStudents, IEnumerable<ICommonStudent>
{

}

public interface IDummersingStudents
{
    IEnumerable<ICommonStudent> Dummers();
}