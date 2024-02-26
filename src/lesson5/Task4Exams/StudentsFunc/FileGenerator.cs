namespace Task4Exams.StudentsFunc;

public class FileGenerator
{
    const int SIZE = 30;
    private Random _rnd = new ();
    protected IFile File = new FileAdapter(); 

    private string[] _names = { "Иван", "Петр", "Сергей", "Андрей", "Алексей", "Федосей", "Барин", "Вася", "Егор", "Алексей", "Саня", "Митя", "Миша", "Костя", "Юра" };
    private string[] _surnames = { "Танк", "Город", "Троллейбус", "Свет", "Черн", "Гор", "Чемодан" };
    private string[] _surnamesEnd = { "ов", "вин", "ив", "еев", "рев", "ван", "фан", "ев" };

    public void GenerateDataFile(string path)
    {
        var lines = new List<string>();
        for (var i = 0; i < SIZE; i++)
        {
            var surname = _surnames[_rnd.Next(_surnames.Length - 1)];
            var surnameEnd = _surnamesEnd[_rnd.Next(_surnamesEnd.Length - 1)];
            var name = _names[_rnd.Next(_names.Length - 1)];
            var count = _rnd.Next(3, 10);
            var valuations = Enumerable.Range(1, count).Select(x => _rnd.Next(2, 6)).ToArray();
            lines.Add($"{surname}{surnameEnd} {name} {string.Join(' ', valuations)}");
        }
        File.WriteAllLines(path, lines.ToArray());
    }
}