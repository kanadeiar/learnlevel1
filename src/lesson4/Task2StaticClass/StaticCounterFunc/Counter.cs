namespace Task2StaticClass.StaticCounterFunc;

public static class Counter
{
    public static IEnumerable<int> Generate(int count)
    {
        var generator = new Generator();
        return generator.GenerateRandomArray(count);
    }

    public static int Count(IEnumerable<int> numbers)
    {
        var counter = new PairsCounter(numbers);
        return counter.CountGoodPairs();
    }

    public static void SaveToFile(IEnumerable<int> numbers, string fileName, 
        IArraySaveFile? save = null)
    {
        var arrayFile = save ?? ArraySaveFile.Create();
        arrayFile.SaveArrayToFile(numbers, fileName);
    }

    public static IEnumerable<int> LoadFromFile(string fileName, 
        IArrayLoadFile? load = null)
    {
        var arrayFile = load ?? ArrayLoadFile.Create();
        return arrayFile.LoadArrayFromFile(fileName);
    }
}