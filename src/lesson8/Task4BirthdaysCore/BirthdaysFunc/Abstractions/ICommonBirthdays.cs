using Kanadeiar.Desktop.Forms;
using Task4BirthdaysCore.BirthdaysFunc.Base;

namespace Task4BirthdaysCore.BirthdaysFunc.Abstractions;

/// <summary>
/// Хранитель дней рождения
/// </summary>
public interface ICommonBirthdays : IEnumerableBirthdays, ISelectableBirthdays, IEditingBirthdays, IFormObservable
{
    string FileName { get; set; }
}

/// <summary>
/// Перечисляемый список дней рождения
/// </summary>
public interface IEnumerableBirthdays : IEnumerable<Birthday>
{

}

/// <summary>
/// Позволяющий выбрать хранитель дней рождения
/// </summary>
public interface ISelectableBirthdays
{
    /// <summary>
    /// Выбранный день рождения
    /// </summary>
    Birthday Selected { get; set; }

    /// <summary>
    /// Выбор дня рождения для показа по индексу
    /// </summary>
    /// <param name="index">Индекс дня рождения</param>
    void Select(int index);
}

/// <summary>
/// Позволяющий редактировать хранитель дней рождения
/// </summary>
public interface IEditingBirthdays
{
    /// <summary>
    /// Добавить день рождения
    /// </summary>
    /// <param name="birthday">Добавляемый день рождения</param>
    void Add(Birthday birthday);

    /// <summary>
    /// Редактировать день рождения
    /// </summary>
    /// <param name="index">Индекс день рождения, которое нужно заменить новым</param>
    /// <param name="birthday">Новый день рождения</param>
    void Edit(int index, Birthday birthday);

    /// <summary>
    /// Удалить день рождения
    /// </summary>
    /// <param name="birthday">Удаляемый день рождения</param>
    void Remove(Birthday birthday);
}