using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        f1.SetDenominator(3);
        Console.WriteLine(f1.GetDenominator());

        f2.SetNumerator(3);
        f2.SetDenominator(4);
        Console.WriteLine(f2.GetDecimalValue());
    }
}