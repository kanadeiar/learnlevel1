using Task5CSVToXMLApp.ConverterModule.Abstractions;

namespace Task5CSVToXMLApp.ConverterModule.Adapters;

internal class StreamReaderAdapter : IStreamReader
{
    private StreamReader _reader;

    public StreamReaderAdapter(string fileName)
    {
        _reader = new StreamReader(fileName);
    }

    public bool EndOfStream => _reader.EndOfStream;

    public string? ReadLine() => _reader.ReadLine();

    public void Dispose() => _reader.Dispose();
}