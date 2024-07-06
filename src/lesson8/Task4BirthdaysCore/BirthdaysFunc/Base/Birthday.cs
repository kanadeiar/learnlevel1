using System.Xml.Serialization;

namespace Task4BirthdaysCore.BirthdaysFunc.Base;

[Serializable]
public struct Birthday
{
    [XmlAttribute]
    public string Surname { get; set; } = string.Empty;

    [XmlAttribute]
    public string Name { get; set; } = string.Empty;

    [XmlAttribute]
    public DateTime Birth { get; set; }

    public Birthday() { }

    public Birthday(string surname, string name, DateTime birth)
    {
        Surname = surname;
        Name = name;
        Birth = birth;
    }

    public void Deconstruct(out string surname, out string name, out DateTime birth)
    {
        surname = Surname;
        name = Name;
        birth = Birth;
    }
}