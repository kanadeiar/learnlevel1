
namespace Task3Students.StudentsFunc;

public class StudentsFactory
{
    protected IFile File = new FileAdapter();

    public ICommonStudents CreateFromFile(string path)
    {
        if (!File.Exists(path)) throw new FileLoadException("Файл отсутствует");

        var lines = readValuesFromFile(path);
        return new Students(lines);
    }

    private IEnumerable<Student> readValuesFromFile(string path)
    {
        var lines = File.ReadAllLines(path);
        var students = new Queue<Student>();
        foreach (var line in lines)
        {
            students.Enqueue(line);
        }

        return students;
    }
}