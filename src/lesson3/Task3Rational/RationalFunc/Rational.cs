using System;
using System.Xml;

namespace Task3Rational.RationalFunc;

public class Rational
{
    private readonly int _numerator;
    private readonly int _denominator;

    public int Numerator => _numerator;
    
    public int Denominator => _denominator;
    
    public Rational(int numerator, int denominator)
    {
        if (denominator == 0) throw new ArgumentException("Знаменатель не может быть навен 0");
        _numerator = numerator;
        _denominator = denominator;
    }

    private Rational plus(Rational other)
    {
        var num = Numerator * other.Denominator + other.Numerator * Denominator;
        var denom = Denominator * other.Denominator;
        return new Rational(num, denom);
    }

    private Rational minus(Rational other)
    {
        var num = Numerator * other.Denominator - other.Numerator * Denominator;
        var denom = Denominator * other.Denominator;
        return new Rational(num, denom);
    }

    private Rational multiply(Rational other)
    {
        var num = Numerator * other.Numerator;
        var denom = Denominator * other.Denominator;
        return new Rational(num, denom);
    }

    private Rational divide(Rational other)
    {
        var num = Numerator * other.Denominator;
        var denom = Denominator * other.Numerator;
        return new Rational(num, denom);
    }

    public double Decimal => Convert.ToDouble(Numerator) / Convert.ToDouble(Denominator);

    public Rational Simplify()
    {
        var (num, denom) = calculateSimplifyValues();
        return new Rational(num, denom);
    }

    private (int, int) calculateSimplifyValues()
    {
        var num = Numerator;
        var denom = Denominator;
        for (var i = findMinimal(); i >= 2; i--)
        {
            if (num % i == 0 && denom % i == 0)
            {
                num /= i;
                denom /= i;
                break;
            }
        }

        return (num, denom);
    }

    private int findMinimal()
    {
        var min = Numerator < Denominator 
            ? Numerator 
            : Denominator;
        return min;
    }

    public static Rational operator +(Rational c1, Rational c2) => c1.plus(c2);
    public static Rational operator -(Rational c1, Rational c2) => c1.minus(c2);
    public static Rational operator *(Rational c1, Rational c2) => c1.multiply(c2);
    public static Rational operator /(Rational c1, Rational c2) => c1.divide(c2);
    public static bool operator == (Rational r1, object r2) => r1.Equals(r2);
    public static bool operator != (Rational r1, object r2) => !(r1 == r2);

    public override bool Equals(object? obj)
    {
        var other = obj as Rational;
        if (other is null) return false;
        return Numerator == other.Numerator && Denominator == other.Denominator;
    }

    public override int GetHashCode()
    {
        return Numerator ^ Denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}