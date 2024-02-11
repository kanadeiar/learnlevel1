namespace Task2NumbersTests.NumbersFunc;

public class AdderTests
{
    [Theory, MemberData(nameof(PlusOddNumbers), "adding")]
    public void TestAddNumber(int[] numbers)
    {
        IAddingAdder adder = new Adder();

        var actual = false;
        foreach (var each in numbers)
        {
            actual = adder.AddNumber(each);
        }

        actual.Should().BeTrue();
        var results = (adder as IValuesAdder)!.Numbers.ToArray();
        results.Should().Equal(numbers);
    }

    [Theory, MemberData(nameof(PlusOddNumbers), "zero")]
    public void TestAddNumber_WhenZero(int[] numbers)
    {
        IAddingAdder adder = new Adder();

        foreach (var each in numbers)
        {
            adder.AddNumber(each);
        }

        var results = (adder as IValuesAdder)!.Numbers.ToArray();
        results[0].Should().Be(100);
        results.Should().HaveCount(1);
    }

    [Theory, MemberData(nameof(PlusOddNumbers), "")]
    public void TestSumPlusOdd(int[] numbers, int expected)
    {
        IAddingAdder adder = new Adder();
        foreach (var each in numbers)
        {
            adder.AddNumber(each);
        }

        var actual = (adder as ICalculatingAdder)!.SumPlusOddNumbers();

        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> PlusOddNumbers(string type)
    {
        switch (type)
        {
            case "adding":
                yield return new object[] { new int[] { 1, 2, 100 } };
                break;
            case "zero":
                yield return new object[] { new int[] { 100, 0, 200 } };
                break;
            default:
                yield return new object[] { new int[] { 1, 5, 6, 0 }, 6 };
                yield return new object[] { new int[] { 1, -2, 7, 0, 9 }, 8 };
                yield return new object[] { new int[] { 1, 3, 0, 9, 8 }, 4 };
                break;
        }
    }
}