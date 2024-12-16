 // ---------------------------------------------------------
        /*
         * --------------------------------------------------
         *     Welcome to Mindfulness Program!
         * --------------------------------------------------
         * This program is an aid to help people to be more
           mindful.
         
         * Author: Christopher Edeson

         * Exceeding Requirements:
         * Added another Activity called GratitudeActivity.cs
         * Implemented a simple user input error handling 
           (for integers only) when making a choice.
        */
// ----------------------------------------------------------

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        string menu =
            @"Menu Options:
            1. Start Breathing Activity
            2. Start Reflecting Activity
            3. Start Listing Activity
            4. Start Gratitude Activity
            5. Quit";

        int choice;
        do
        {
            Console.WriteLine(menu);
            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    break;
                case 2:
                    new ReflectingActivity().Run();
                    break;
                case 3:
                    new ListingActivity().Run();
                    break;
                case 4:
                    new GratitudeActivity().Run();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        } while (choice != 5);
    }
}