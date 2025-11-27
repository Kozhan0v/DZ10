using System;

namespace Tumakov12.Classes
{
    internal class Complex
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static bool operator ==(Complex num1, Complex num2)
        {
            return num1.Real == num2.Real && num1.Imaginary == num2.Imaginary ? true : false;
        }

        public static bool operator !=(Complex num1, Complex num2)
        {
            return num1.Real == num2.Real && num1.Imaginary == num2.Imaginary ? false : true;
        }

        public static Complex operator +(Complex num1, Complex num2)
        {
            return new Complex(num1.Real + num2.Real, num1.Imaginary + num2.Imaginary);
        }

        public static Complex operator -(Complex num1, Complex num2)
        {
            return new Complex(num1.Real - num2.Real, num1.Imaginary - num2.Imaginary);
        }

        public static Complex operator *(Complex num1, Complex num2)
        {
            double real = num1.Real * num2.Real - num1.Imaginary * num2.Imaginary;
            double imaginary = num1.Real * num2.Imaginary + num2.Real * num1.Imaginary;

            return new Complex(real, imaginary);
        }

        public override bool Equals(object obj)
        {
            Complex num = obj as Complex;

            if (num is not null)
            {
                return Real == num.Real && Imaginary == num.Imaginary ? true : false;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (Real + Imaginary).GetHashCode();
        }

        public override string ToString()
        {
            if (Real == 0)
            {
                return $"{Imaginary}i";
            }
            else if (Imaginary == 0)
            {
                return $"{Real}";
            }
            else if (Imaginary < 0)
            {
                return $"{Real}{Imaginary}i";
            }
            else
            {
                return $"{Real}+{Imaginary}i";
            }
        }
    }
}
