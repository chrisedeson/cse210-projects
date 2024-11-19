using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction(1, 3);
        // Fraction fraction2 = new Fraction();

        // // Verify Setters and Getters

        int top = fraction1.GetTop();
        int bottom = fraction1.GetBottom();

        Console.WriteLine($"Top: {top}");
        Console.WriteLine($"Bottom: {bottom}");
        Console.WriteLine("");

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        
        
    }
}