using Task4BirthdaysCore.BirthdaysFunc.Base;

namespace Task4BirthdaysCore.BirthdaysFunc.Abstractions;

public interface ICommonBirthdays : IEnumerableBirthdays, IEditingBirthdays
{
}

public interface IEditingBirthdays
{
    void Add(Birthday birthday);
    void Remove(Birthday birthday);
}

public interface IEnumerableBirthdays : IEnumerable<Birthday>
{

}