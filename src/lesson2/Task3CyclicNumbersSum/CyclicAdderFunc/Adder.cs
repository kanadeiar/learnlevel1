namespace Task3CyclicNumbersSum.CyclicAdderFunc;

public class Adder : ICommonAdder
{
    private IList<int> _numbers = new List<int>();
    private bool _isEnd = false;

    public IEnumerable<int> Numbers => _numbers;
    
    private Adder()
    {
        
    }

    public static ICommonAdder CreateInstance()
    {
        return new Adder();
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

    public int SumPlusOdd()
    {
        var result = 0;
        foreach (var each in Numbers)
        {
            if (each > 0 && each % 2 != 0)
            {
                result += each;
            }
        }
        return result;
    }
}



