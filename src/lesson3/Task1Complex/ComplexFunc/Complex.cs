namespace Task1Complex.ComplexFunc;

public class Complex
{
    private readonly double _re;
    private readonly double _im;

    public double Re => _re;

    public double Im => _im;

    public Complex(double re, double im)
    {
        _re = re;
        _im = im;
    }

    private Complex plus(Complex other)
    {
        var re = _re + other._re;
        var im = _im + other._im;
        return new Complex(re, im);
    }

    private Complex minus(Complex other)
    {
        var re = _re - other._re;
        var im = _im - other._im;
        return new Complex(re, im);
    }

    private Complex multiply(Complex other)
    {
        var re = _re * other._re - _im * other._im;
        var im = _im * other._re + _re * other._im;
        return new Complex(re, im);
    }

    private Complex divide(Complex other)
    {
        var re = (_re * other._re + _im * other._im) / (Math.Pow(other._re, 2) + Math.Pow(other._im, 2));
        var im = (_im * other._re - _re * other._im) / (Math.Pow(other._re, 2) + Math.Pow(other._im, 2));
        return new Complex(re, im);
    }

    public static Complex operator +(Complex c1, Complex c2) => c1.plus(c2);

    public static Complex operator -(Complex c1, Complex c2) => c1.minus(c2);

    public static Complex operator *(Complex c1, Complex c2) => c1.multiply(c2);

    public static Complex operator /(Complex c1, Complex c2) => c1.divide(c2);

    public static bool operator == (Complex c1, object c2) => c1.Equals(c2);

    public static bool operator != (Complex c1, object c2) => !(c1 == c2);

    public override bool Equals(object? obj)
    {
        var other = obj as Complex;
        if (other is null) return false;
        return Math.Abs(_re - other._re) < 0.1 && Math.Abs(_im - other._im) < 0.1;
    }

    public override int GetHashCode()
    {
        return Convert.ToInt32(_re) ^ Convert.ToInt32(_im);
    }

    public override string ToString()
    {
        return $"{_re}+{_im}i";
    }
}