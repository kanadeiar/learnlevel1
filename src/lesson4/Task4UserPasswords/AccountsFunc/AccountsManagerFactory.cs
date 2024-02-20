namespace Task4UserPasswords.AccountsFunc;

public class AccountsManagerFactory
{
    protected IFile File = new FileAdapter();

    public ICheckingAccountsManager Create(IEnumerable<(string, string)> accounts)
    {
        return new AccountsManager(accounts);
    }

    public ICheckingAccountsManager CreateFromFile(string fileName)
    {
        if (!File.Exists(fileName)) throw new FileLoadException("Файл отсутствует");

        var accounts = readArrayFromFile(fileName);
        return new AccountsManager(accounts);
    }

    private IEnumerable<(string, string)> readArrayFromFile(string fileName)
    {
        string[] strings = File.ReadAllLines(fileName);
        for (var i = 0; i < strings.Length; i++)
        {
            var strs = strings[i].Split(',');
            yield return (strs[0], strs[1]);
        }
    }
}