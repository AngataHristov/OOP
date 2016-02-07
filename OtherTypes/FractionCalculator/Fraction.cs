
namespace FractionCalculator
{
    using System;
    using System.Numerics;

    public struct Fraction
    {
        private long numerator;
        private long denomirator;

        public Fraction(long numerator, long denumerator) : this()
        {
            // long gcd = GCD(numerator, denumerator);
            // this.Numerator = numerator / gcd;
            // this.Denominator = denumerator / gcd;
            this.Numerator = numerator;
            this.Denominator = denumerator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            private set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denomirator;
            }
            private set
            {
                if (value < long.MinValue || value > long.MaxValue)
                {
                    throw new StackOverflowException("You are out of the size of type long!");
                }
                if (value == 0)
                {
                    throw new ArgumentException("Denumerator cannot be zero!");
                }
                this.denomirator = value;
            }
        }

        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            long newNumerator = firstFraction.Numerator * secondFraction.Denominator + firstFraction.Denominator * secondFraction.Numerator;
            long commonDenom = firstFraction.Denominator * secondFraction.Denominator;

            return new Fraction(newNumerator, commonDenom);
        }

        public static Fraction operator -(Fraction firstFraction, Fraction secondFraction)
        {
            long newNumerator = firstFraction.Numerator * secondFraction.Denominator - firstFraction.Denominator * secondFraction.Numerator;
            long commonDenom = firstFraction.Denominator * secondFraction.Denominator;

            return new Fraction(newNumerator, commonDenom);
        }

        public override string ToString()
        {
            return ((double)this.Numerator / this.Denominator).ToString();
        }

        // private static long GCD(long num1, long num2)
        // {
        //     long Remainder;
        // 
        //     while (num2 != 0)
        //     {
        //         Remainder = num1 % num2;
        //         num1 = num2;
        //         num2 = Remainder;
        //     }
        // 
        //     return num1;
        // }
    }
}
