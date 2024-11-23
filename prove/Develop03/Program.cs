 // ------------------------------------------------------
        /*
         * -----------------------------------------------
         *     Welcome to Scripture Memorizer Program!
         * -----------------------------------------------
         * This program is an aid to help people better 
           memorize a scripture.
         
         * Author: Christopher Edeson

         * Exceeding Requirements:
         * Have the program work with a library of scriptures 
           rather than a single one. Choose scriptures at 
           random to present to the user.
        */
// -------------------------------------------------------

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");

       // library of scriptures
        Dictionary<Reference, string> scriptureLibrary = new Dictionary<Reference, string>
        {
            { new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son" },
            { new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths" },
            { new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want" }
        };

        // Select a random scripture from the library
        Random rand = new Random();
        List<Reference> keys = new List<Reference>(scriptureLibrary.Keys);
        Reference randomReference = keys[rand.Next(keys.Count)];
        string scriptureText = scriptureLibrary[randomReference];

        // Create the Scripture object with the chosen reference and text
        Scripture scripture = new Scripture(scriptureText);

        Console.Clear(); // clear the console
        Console.WriteLine(randomReference.GetDisplayText() + " - " + scripture.GetDisplayText());

        // Keep hiding words until the scripture is completely hidden
        while (!scripture.isCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
            Console.Clear();
            Console.WriteLine(randomReference.GetDisplayText() + " - " + scripture.GetDisplayText());
        }

        Console.WriteLine("\nGoodbye! Happy Memorizing!");
    }
}
