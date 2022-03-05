using System;

namespace Lab1
{
    class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction(Fraction fraction)
        {
            return new Fraction(fraction.numerator, fraction.denominator);
        }

        private int _numerator;

        public int numerator
        {
            get => _numerator;
        }

        private int _denominator;

        public int denominator
        {
            get => _denominator;
        }

        public override bool Equals(Fraction other)
        {
            if (other == null)
            {
                return false;
            }

            if (_numerator / other.numerator == _denominator / other.denominator)
            {
                return true;
            }

            return false;
        }

        public override int CompareTo(Fraction other)
        {
            if (other == null)
            {
                return 1;
            }

            double ratio = _numerator / _denominator;
            double otherRatio = other.numerator / other.denominator;

            return ratio.CompareTo(otherRatio);
        }

        public override string ToString()
        {
            string numerator = numerator.ToString();
            string denominator = denominator.ToString();

            return numerator + "/" + denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }

            return new Fraction(a.num * b.den, a.den * b.num);
        }
    }

    class Lab1
    {

    }
}