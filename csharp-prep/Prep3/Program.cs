using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Guess My Number game
        string playAgain;

        do
        {
            int guess;
            Random randomMagicNumber = new Random();
            int magicNumber = randomMagicNumber.Next(1, 101);
            Console.Write($"\nWhat is the magic number? {magicNumber}\n");

            int count = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                Console.WriteLine("You guessed it!");
                }
                
                count++;
            } while (magicNumber != guess);

            Console.WriteLine($"You made {count} guesses");
            
            Console.Write($"\nDo you want to play again? ");
            playAgain = Console.ReadLine();

        } while( playAgain == "yes");

    }
}