namespace Task5CSVToXMLApp.ConverterModule;

[Serializable]
public class Student
{
    public string FirstName { get; set; } = string.Empty;
    public string SecondName { get; set; } = string.Empty;
    public string University { get; set; } = string.Empty;
    public string Facility { get; set; } = string.Empty;
    public string Departament { get; set; } = string.Empty;
    public int Age { get; set; }
    public int Course { get; set; }
    public int Group { get; set; }
    public string City { get; set; } = string.Empty;

    public override string ToString() => 
        $"{FirstName} {SecondName} {University} {Facility} {Departament} {Age} {Course} {Group} {City}";
}