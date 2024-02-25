namespace Task1CheckLogin.CheckLoginFunc;

public abstract class Checker : ICheckingChecker
{
    private string? _login;

    protected string? Login
    {
        get => _login;
        set => _login = value;
    }

    public static ICheckingChecker Create(CheckCode code)
    {
        return code switch
        {
            CheckCode.Simple => new SimpleChecker(),
            CheckCode.WithRegex => new WithRegexChecker(),
            _ => throw new IndexOutOfRangeException(nameof(code))
        };
    }

    public abstract bool Check(string? login);
}