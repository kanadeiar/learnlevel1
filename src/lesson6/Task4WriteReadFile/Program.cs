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
        var stream = WriterReaderFactory.Create(MethodCode.Stream, "streamingfile.txt");
        stream.Write(data);
        
        var binary = WriterReaderFactory.Create(MethodCode.Binary, "binary.txt");
        binary.Write(data);
        
        var streams = WriterReaderFactory.Create(MethodCode.CharStreams, "writestream.txt");
        streams.Write(data);

        var buffred = WriterReaderFactory.Create(MethodCode.Buffered, "buffered.txt");
        buffred.Write(data);

        ConsoleHelper.Pause("Данные в файлы записаны. Для продолжения нажмите кнопку ...");
        Console.WriteLine();
    }

    private static void simpleStreamReadAndPrint()
    {
        Console.WriteLine("Простой файловый поток. Прочитанные данные:");
        var stream = WriterReaderFactory.Create(MethodCode.Stream, "streamingfile.txt");
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
        var stream = WriterReaderFactory.Create(MethodCode.Binary, "binary.txt");
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
        var stream = WriterReaderFactory.Create(MethodCode.CharStreams, "writestream.txt");
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
        var stream = WriterReaderFactory.Create(MethodCode.Buffered, "buffered.txt");
        var data = stream.Read();
        foreach (var each in data)
        {
            Console.Write("{0} ", each);
        }
        Console.WriteLine();
    }
}