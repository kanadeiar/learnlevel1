using System.Collections;

namespace Task4BirthdaysCore.BirthdaysFunc.Base;

public class BirthdaysData : IEnumerable<Birthday>
{
    private List<Birthday> _birthdays;

    public BirthdaysData(List<Birthday>? birthdays = null)
    {
        _birthdays = birthdays ?? new List<Birthday>();
    }

    public void Add(Birthday birthday) => _birthdays.Add(birthday);

    public void Remove(Birthday birthday) => _birthdays.Remove(birthday);

    public IEnumerator<Birthday> GetEnumerator() => _birthdays.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_birthdays).GetEnumerator();
}