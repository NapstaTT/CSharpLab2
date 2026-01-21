namespace Lab2.Classes
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Знаменатель не может быть нулём.");
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            int num = Numerator * other.Denominator + other.Numerator * Denominator;
            int den = Denominator * other.Denominator;
            return new Fraction(num, den).Simplify();
        }

        public Fraction Add(int number)
        {
            return Add(new Fraction(number, 1));
        }

        public Fraction Subtract(Fraction other)
        {
            int num = Numerator * other.Denominator - other.Numerator * Denominator;
            int den = Denominator * other.Denominator;
            return new Fraction(num, den).Simplify();
        }

        public Fraction Subtract(int number)
        {
            return Subtract(new Fraction(number, 1));
        }

        public Fraction Multiply(Fraction other)
        {
            return new Fraction(Numerator * other.Numerator, Denominator * other.Denominator).Simplify();
        }

        public Fraction Multiply(int number)
        {
            return Multiply(new Fraction(number, 1));
        }

        public Fraction Divide(Fraction other)
        {
            return new Fraction(Numerator * other.Denominator, Denominator * other.Numerator).Simplify();
        }

        public Fraction Divide(int number)
        {
            return Divide(new Fraction(number, 1));
        }

        private Fraction Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            return new Fraction(Numerator / gcd, Denominator / gcd);
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}