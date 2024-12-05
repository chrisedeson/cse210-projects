using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Assignment first = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(first.GetSummary());

        Console.WriteLine();

        MathAssignment second = new MathAssignment("7.3", "8-19", "Roberto Carlos", "Fractions");
        // Console.WriteLine(second.GetSummary());
        Console.WriteLine(second.GetHomeworkList());

        Console.WriteLine();
        WritingAssignment third = new WritingAssignment("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(third.GetWritingInformation());
    }
}