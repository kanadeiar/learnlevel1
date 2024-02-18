namespace Task3BestArrayClass.BestArrayFunc;

public interface ICommonBestArray : IInfoBestArray, IGettingBestArray
{

}

public interface IInfoBestArray
{
    int Max { get; }
    int Sum { get; }
    object MaxCount { get; }
    int Length { get; }
    int this[int i] { get; set; }
    string ToString();
}

public interface IGettingBestArray
{
    Dictionary<int, int> FrequencyDictionary();
    ICommonBestArray Inverse { get; }
    ICommonBestArray Multiply(int value);
}