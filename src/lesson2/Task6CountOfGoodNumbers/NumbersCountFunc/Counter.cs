namespace Task6CountOfGoodNumbers.NumbersCountFunc;

public class Counter : ICountCounter
{
    public Counter()
    {
        
    }

    public long Count(int top)
    {
        long sum = default;
        for (int i = 1; i < top; i++)
        {
            if (isGood(i))
            {
                sum += i;
            }
        }
        return sum;
    }

    private static bool isGood(int number)
    {
        return (number % sumNumbers(number) == 0);
    }

    private static int sumNumbers(int number)
    {
        int sum = default;
        while (number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }
        return sum;
    }
}