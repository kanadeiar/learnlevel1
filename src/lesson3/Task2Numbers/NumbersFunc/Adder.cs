namespace Task2Numbers.NumbersFunc;

public class Adder : ICommonAdder
{
    private readonly IList<int> _numbers = new List<int>();
    private bool _isEnd = false;

    public IEnumerable<int> Numbers => _numbers;

    public Adder()
    {
        
    }

    public bool AddNumber(int number)
    {
        if (isEnd(number)) return false;

        _numbers.Add(number);
        return true;
    }

    private bool isEnd(int number)
    {
        if (_isEnd) return true;
        _isEnd = number == 0;
        return _isEnd;
    }

    public int SumPlusOddNumbers()
    {
        var result = 0;
        foreach (var each in Numbers)
        {
            if (isGoodNumber(each))
            {
                result += each;
            }
        }
        return result;
    }

    private static bool isGoodNumber(int number) => number > 0 && number % 2 != 0;
}