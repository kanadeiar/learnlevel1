namespace Task4Exams.StudentsFunc;

public class StudentsFactory
{
    protected IFile File = new FileAdapter();

    public ICommonStudents CreateFromFile(string path)
    {
        if (!File.Exists(path)) throw new FileLoadException("Файл отсутствует");

        var lines = readValuesFromFile(path);
        return new Students(lines);
    }

    private IEnumerable<ICommonStudent> readValuesFromFile(string path)
    {
        var lines = File.ReadAllLines(path);
        var results = lines.Select(line =>
        {
            var strs = line.Split(' ');
            var count = strs.Length - 2;
            var valuations = new int[count];
            for (int i = 0; i < count; i++)
            {
                valuations[i] = int.Parse(strs[i + 2]);
            }
            return new Student(strs[0], strs[1], valuations);
        });
        
        return results;
    }
}