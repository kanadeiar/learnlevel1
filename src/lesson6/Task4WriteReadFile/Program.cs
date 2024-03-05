namespace Task4WriteReadFile;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 4", "Задача № 4. Запись и чтение файла.");

        var size = 100;

        createFilesWithTestValues(size);

        simpleStreamReadAndPrint();
        binaryReadAndPrint();
        readStreamReadAndPrint();
        bufferedStreamReadAndPrint();

        ConsoleHelper.PrintFooter();
    }

    private static void createFilesWithTestValues(int size)
    {
        var data = Enumerable.Range(1, size).Select(x => (byte)x).ToArray();
        var stream = WriterReaderFactory.StreamCreate("streamingfile.txt");
        stream.Write(data);
        
        var values = Enumerable.Range(1, size).Select(x => x).ToArray();
        var binary = WriterReaderFactory.BinaryCreate("binary.txt");
        binary.Write(values);
        
        var chars = Enumerable.Range(1, size).Select(x => (char)x).ToArray();
        var streams = WriterReaderFactory.StreamsCreate("writestream.txt");
        streams.Write(chars);

        var buffred = WriterReaderFactory.BufferedCreate("buffered.txt");
        buffred.Write(data);

        ConsoleHelper.Pause("Данные в файлы записаны. Для продолжения нажмите кнопку ...");
        Console.WriteLine();
    }

    private static void simpleStreamReadAndPrint()
    {
        Console.WriteLine("Простой файловый поток. Прочитанные данные:");
        var stream = WriterReaderFactory.StreamCreate("streamingfile.txt");
        var data = stream.Read();
        foreach (var each in data)
        {
            Console.Write("{0} ", each);
        }
        Console.WriteLine();
    }

    private static void binaryReadAndPrint()
    {
        Console.WriteLine("Поток бинарных данных. Прочитанные данные:");
        var stream = WriterReaderFactory.BinaryCreate("binary.txt");
        var data = stream.Read();
        foreach (var each in data)
        {
            Console.Write("{0} ", each);
        }
        Console.WriteLine();
    }

    private static void readStreamReadAndPrint()
    {
        Console.WriteLine("Отдельный поток чтения данных. Прочитанные данные:");
        var stream = WriterReaderFactory.StreamsCreate("writestream.txt");
        var data = stream.Read();
        foreach (var each in data)
        {
            Console.Write("{0} ", each);
        }
        Console.WriteLine();
    }

    private static void bufferedStreamReadAndPrint()
    {
        Console.WriteLine("Буферизированный поток. Прочитанные данные:");
        var stream = WriterReaderFactory.BufferedCreate("buffered.txt");
        var data = stream.Read();
        foreach (var each in data)
        {
            Console.Write("{0} ", each);
        }
        Console.WriteLine();
    }
}