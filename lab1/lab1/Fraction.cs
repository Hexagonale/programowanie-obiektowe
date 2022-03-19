using System;

namespace lab1
{
    class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        public Fraction()
        {
            this.numerator = 1;
            this.denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(Fraction fraction)
        {
            numerator = fraction.numerator;
            denominator = fraction.denominator;
        }

        public int numerator { get; }

        public int denominator { get; }

        public override bool Equals(Fraction other)
        {
            if (other == null)
            {
                return false;
            }

            if (numerator / other.numerator == denominator / other.denominator)
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

            double ratio = numerator / denominator;
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
}
