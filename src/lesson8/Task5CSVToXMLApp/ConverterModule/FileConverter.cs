using System.Runtime.CompilerServices;
using Task5CSVToXMLApp.ConverterModule.Abstractions;
using Task5CSVToXMLApp.ConverterModule.Adapters;

[assembly: InternalsVisibleTo("Task5CSVToXMLAppTests")]
namespace Task5CSVToXMLApp.ConverterModule;

public class FileConverter
{
    internal IStreamReader? streamReader;
    internal IXmlFileSerializer<List<Student>>? xmlSerializer;

    public Students GetStudentsFromCSVFile(string fileName)
    {
        var students = new List<Student>();

        using (var reader = streamReader ??= new StreamReaderAdapter(fileName))
        {
            while (!reader.EndOfStream)
            {
                string str = reader.ReadLine()!;
                string[] strs = str.Split(';');
                var student = new Student()
                {
                    FirstName = strs[0],
                    SecondName = strs[1],
                    University = strs[2],
                    Facility = strs[3],
                    Course = int.Parse(strs[4]),
                    Departament = strs[5],
                    Group = int.Parse(strs[6]),
                    City = strs[7],
                    Age = int.Parse(strs[8]),
                };
                students.Add(student);
            }
        }

        return new Students(students);
    }

    public void SaveStudentsToXMLFile(List<Student> students, string fileName)
    {
        var serializer = xmlSerializer ?? new XmlFileSerializerAdapter<List<Student>>();

        serializer.SerializeAndSave(students, fileName);
    }
}