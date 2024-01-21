using Lesson1Anketa.AnketaFeat;

namespace Lesson1Tests.AnketaFeat;

public class AnketaFixture : IDisposable
{
    public IFaсtoryAnketa Anketa;

    public AnketaFixture()
    {
        Anketa = IFaсtoryAnketa.Create();

        Anketa.Name = "Test1";
        Anketa.SurName = "TestFam1";
        Anketa.Age = 10;
        Anketa.Height = 80;
        Anketa.Weight = 49;
    }
    
    public void Dispose()
    {
        Anketa = null;
    }
}