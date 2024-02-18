namespace Task4UserPasswords.AccountsFunc;

public class AccountsManagerFactory
{
    public ICheckingAccountsManager Create(IEnumerable<(string, string)> accounts)
    {
        return new AccountsManager(accounts);
    }

    public ICheckingAccountsManager CreateFromFile(string fileName, IFile? adapter = null)
    {
        var file = adapter ?? new FileAdapter();
        if (!file.Exists(fileName)) throw new FileLoadException("Файл отсутствует");

        var accounts = readArrayFromFile(fileName, file);
        return new AccountsManager(accounts);
    }

    private static IEnumerable<(string, string)> readArrayFromFile(string fileName, IFile file)
    {
        string[] strings = file.ReadAllLines(fileName);
        for (var i = 0; i < strings.Length; i++)
        {
            var strs = strings[i].Split(',');
            yield return (strs[0], strs[1]);
        }
    }
}