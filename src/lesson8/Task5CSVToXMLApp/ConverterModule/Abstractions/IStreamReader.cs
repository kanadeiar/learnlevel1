namespace Task5CSVToXMLApp.ConverterModule.Abstractions;

public interface IStreamReader : IDisposable
{
    bool EndOfStream { get; }
    string? ReadLine();
}