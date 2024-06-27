using System.Collections;

namespace Task3GameEditorCore.BelieveOrNotBelieveFunc;

public class QuestionsData : IEnumerable<Question>
{
    private List<Question> _questions;

    public QuestionsData(List<Question>? questions)
    {
        _questions = questions ?? new List<Question>();
    }

    public void AddQuestion(string text, bool isTrue)
    {
        _questions.Add(new Question(text, isTrue));
    }

    public void RemoveQuestionAt(int index)
    {
        if (index < _questions.Count && index >= 0)
        {
            _questions.RemoveAt(index);
        }
    }

    public Question this[int index] => _questions[index];

    public int Count => _questions.Count;

    public IEnumerator<Question> GetEnumerator()
    {
        return _questions.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_questions).GetEnumerator();
    }
}