namespace Task1CheckLogin.CheckLoginFunc.CheckBase;

internal class SimpleChecker : Checker
{
    public override bool Check(string? login)
    {
        Login = login;
        return simpleValidation();
    }

    private bool simpleValidation()
    {
        if (Login is null) return false;

        if (Login.Length < 2 || Login.Length > 10)
            return false;
        if (char.IsDigit(Login[0]))
            return false;
        for (int i = 0; i < Login.Length; i++)
        {
            char c = char.ToLower(Login[i]);
            if (!(c >= 'a' && c <= 'z' || char.IsDigit(c)))
                return false;
        }
        return true;
    }
}