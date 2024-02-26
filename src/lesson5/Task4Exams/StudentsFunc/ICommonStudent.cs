namespace Task4Exams.StudentsFunc;

public interface ICommonStudent : IAveragingStudent
{
    string ToString();
}

public interface IAveragingStudent
{
    double Average { get; }
}