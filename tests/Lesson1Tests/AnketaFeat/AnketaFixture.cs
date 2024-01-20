using Lesson1Anketa.AnketaFeat;

namespace Lesson1Tests.AnketaFeat;

public class AnketaFixture
{
    public Anketa Anketa;

    public AnketaFixture()
    {
        Anketa = new Anketa();

        Anketa.Name = "Test1";
        Anketa.SurName = "TestFam1";
        Anketa.Age = 10;
        Anketa.Height = 80;
        Anketa.Weight = 49;
    }
}