using Kanadeiar.Common;

internal class Program
{
    public static void Main(string[] args)
    {
        ConsoleHelper.PrintHeader("Задача № 4", "Задача № 4. Ввод логина и пароля.");

        var userPassword = new UserPassword();
        var checkpoint = Checkpoint.Create(new UserPasswordFuncAdapter(userPassword));

        while (true)
        {
            var username = ConsoleHelper.ReadLineFromConsole("Введите имя пользователя")!;
            var password = ConsoleHelper.ReadLineFromConsole("Введите пароль")!;
            var isCorrect = checkpoint.CheckUserPassword(username, password);
    
            if (isCorrect)
            {
                Console.WriteLine("Доступ разрешен");
                break;
            }

            if (checkpoint.IsBlocked())
            {
                Console.WriteLine("Превышено число попыток. Доступ в систему заблокирован");
                break;
            }

            Console.WriteLine("Введена неверная пара логин / пароль, повторите попытку");
        }




        ConsoleHelper.PrintFooter();
    }
}