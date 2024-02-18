using Kanadeiar.Common.Console;

namespace Task4UserPasswords;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 2", "Задача № 2. Статический класс и чтение из файла.");

        Console.WriteLine("Введите логин и пароль, 3 попытки");

        var (isAuthorized, login) = authorizeToSystem();

        if (isAuthorized)
        {
            Console.WriteLine($"Здравствуйте, {login}! Вы успешно вошли в всистему! Логин пароль правильные.");
            Console.Beep();
        }
        else
        {
            Console.WriteLine("Прощайте! Вам не удалось войти в систему. Кончились попытки ввода логина и пароля.");
            Console.Beep();
        }

        ConsoleHelper.PrintFooter();
    }

    private static (bool, string) authorizeToSystem()
    {
        var manager = AccountsManager.Factory.CreateFromFile("data.txt");
        var checkpoint = Checkpoint.Create(new UserPasswordFuncAdapter(manager));

        while (checkpoint.IsBlocked() == false)
        {
            var login = ConsoleHelper.ReadLineFromConsole("Введите логин")!;
            var password = ConsoleHelper.ReadLineFromConsole("Введите пароль")!;
            if (checkpoint.CheckUserPassword(login, password))
            {
                return (true, login);
            }

            Console.WriteLine("Неверно введены логин и пароль");
        }
        return (false, null!);
    }
}