using Task3GameEditorCore.BelieveOrNotBelieveFunc.Base;

namespace Task3GameEditorCore.BelieveOrNotBelieveFunc.Abstractions;

public interface ITrueFalse
{
    /// <summary>
    /// Добавить новый вопрос
    /// </summary>
    /// <param name="text">Текст вопроса</param>
    /// <param name="isTrue">Истинна вопроса</param>
    void Add(string text, bool isTrue);

    /// <summary>
    /// Удалить вопрос по индексу
    /// </summary>
    /// <param name="index">Индекс вопроса</param>
    void Remove(int index);

    /// <summary>
    /// Получить вопрос по индексу
    /// </summary>
    /// <param name="index">Индекс</param>
    /// <returns>Вопрос и его истинность</returns>
    Question this[int index] { get; }
    
    /// <summary>
    /// Количество вопросов
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Сохранить вопросы в файл
    /// </summary>
    void Save();
    
    /// <summary>
    /// Загрузить вопросы из файла
    /// </summary>
    void Load();
}