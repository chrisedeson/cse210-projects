using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your grade percentage? ");
        string getUserGrade = Console.ReadLine();
        int userGrade = int.Parse(getUserGrade);

        string letter; // Letter grade

        if (userGrade >= 90)
        {
            // Console.WriteLine("A");
            letter = "A";
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            // Console.WriteLine("B");
            letter = "B";
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            // Console.WriteLine("C");
            letter = "C";
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            // Console.WriteLine("D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("F");
            letter = "F";
        }

        // To add the sign to the letter grade, either "+", "-"
        string sign;
        int lastDigit = userGrade % 10; // Modulus operator (%) gets the remainder when you divide by 10
        // Console.WriteLine(lastDigit);

        if (lastDigit >= 7 && userGrade < 93 && userGrade > 60)
        // Recognize that there is no A+ grade, only A and A-
        {
            sign = "+";
        }
        else if (lastDigit < 3 && userGrade > 59)
        // recognize that there is no F+ or F- grades, only F.
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine(letter + sign);


        if (userGrade >= 70)
        {
            Console.WriteLine("\nCongratulations! You Pass!\n");
        }
        else
        {
            Console.WriteLine("\nI'm sorry, you do not pass. Better luck next time!\n");
        }

        
    }
}