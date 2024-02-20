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
        var strings = File.ReadAllLines(fileName);
        foreach (var each in strings)
        {
            var strs = each.Split(',');
            yield return (strs[0], strs[1]);
        }
    }
}