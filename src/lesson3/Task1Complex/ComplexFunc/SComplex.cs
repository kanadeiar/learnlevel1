
namespace Task1Complex.ComplexFunc;

public struct SComplex
{
    private readonly double _re;
    private readonly double _im;

    public double Re => _re;

    public double Im => _im;

    public SComplex(double re, double im)
    {
        _re = re;
        _im = im;
    }

    private SComplex plus(SComplex other)
    {
        var re = _re + other._re;
        var im = _im + other._im;
        return new SComplex(re, im);
    }

    private SComplex minus(SComplex other)
    {
        var re = _re - other._re;
        var im = _im - other._im;
        return new SComplex(re, im);
    }

    private SComplex multiply(SComplex other)
    {
        var re = _re * other._re - _im * other._im;
        var im = _im * other._re + _re * other._im;
        return new SComplex(re, im);
    }

    private SComplex divide(SComplex other)
    {
        var re = (_re * other._re + _im * other._im) / (Math.Pow(other._re, 2) + Math.Pow(other._im, 2));
        var im = (_im * other._re - _re * other._im) / (Math.Pow(other._re, 2) + Math.Pow(other._im, 2));
        return new SComplex(re, im);
    }

    public static SComplex operator +(SComplex c1, SComplex c2) => c1.plus(c2);

    public static SComplex operator -(SComplex c1, SComplex c2) => c1.minus(c2);

    public static SComplex operator *(SComplex c1, SComplex c2) => c1.multiply(c2);

    public static SComplex operator /(SComplex c1, SComplex c2) => c1.divide(c2);

    public override string ToString()
    {
        return $"{_re}+{_im}i";
    }
}