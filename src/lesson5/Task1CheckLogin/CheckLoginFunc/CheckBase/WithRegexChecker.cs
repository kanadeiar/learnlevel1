namespace Task1CheckLogin.CheckLoginFunc.CheckBase;

internal class WithRegexChecker : Checker
{
    public override bool Check(string? login)
    {
        Login = login;
        return regexValidation();
    }

    private bool regexValidation()
    {
        if (Login is null) return false;

        var regex = new Regex(@"^[a-z][a-z\d]{1,9}$", RegexOptions.IgnoreCase);
        return regex.IsMatch(Login);
    }
}