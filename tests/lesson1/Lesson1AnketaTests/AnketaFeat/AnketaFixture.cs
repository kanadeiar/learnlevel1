using Lesson1Anketa.AnketaFeat;

namespace Lesson1AnketaTests.AnketaFeat;

public class AnketaFixture : IDisposable
{
    public IFaсtoryAnketa Ank;

    public AnketaFixture()
    {
        Ank = Anketa.Create();

        Ank.Name = "Test1";
        Ank.SurName = "TestFam1";
        Ank.Age = 10;
        Ank.Height = 80;
        Ank.Weight = 49;
    }
    
    public void Dispose()
    {
        Ank = null;
    }
}