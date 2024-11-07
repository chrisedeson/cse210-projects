using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<double> numbers= new List<double>();
        double number;               // to store the input from the user
        double sum = 0;              // sum
        double average;              // average
        double largestNum = 0;       // largest number
        double smallestPositive;     // smallest positive number

        do
        {
            Console.Write("Enter number: ");
            number = double.Parse(Console.ReadLine());

            // Do not add 0 into the list
            if (number != 0)
            {
                numbers.Add(number); // add new number to the List
            }
        } while(number != 0);

        foreach (double num in numbers)
        {
            // Console.WriteLine(num);
            sum += num;

            // if the current number is greater than the largest Number. . 
            // . . assign that number to be the new largest number
            if (num > largestNum)
            {
                largestNum = num;
            }
            
        }
            smallestPositive = largestNum;
            foreach (double num in numbers)
            {
                if (num > 0 && num != 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }

            average = sum / numbers.Count;
            Console.WriteLine("");
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largestNum}");
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

    }
}