 // ------------------------------------------------------
        /*
         * -----------------------------------------------
         *     Welcome to the Journal Program!
         * -----------------------------------------------
         * This program allows you to write, save, 
         * and display journal entries.
         *
         * Author: Christopher Edeson

         * Exceeding Requirements:
         * - Implemented some error handling, especially
         *   when user inputs invalid choice.
         * - Handles commas and quotes when loading file.
         * - Excel Compactibility.
        */
// -------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program!");
        
        PromptGenerator prompt = new PromptGenerator();
        string choice;
        bool exitProgram = false;   // Variable for loop until the user chooses to quit

        DateTime now = DateTime.Now;
        string currentDate = now.ToString("dd-MMM-yyyy");

        Journal record = new Journal();

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose to Write!");
                    string currentPrompt = prompt.GetRandomPrompt();
                    Console.WriteLine(currentPrompt);

                    Entry newEntry = new Entry();
                    newEntry._promptText = currentPrompt;      // Prompt
                    newEntry._entryText = Console.ReadLine();  // User entry
                    newEntry._date = currentDate;              // Date of the entry
                    record.AddEntry(newEntry);

                    // Another way of writing this (a shorter way)
                    // // Create a new Entry object
                    // Entry newEntry = new Entry
                    // {
                    //     _promptText = currentPrompt,
                    //     _entryText = userResponse,
                    //     _date = DateTime.Now.ToString("dd-MMM-yyyy")
                    // };
                    break;

                case "2":
                    Console.WriteLine("You chose to Display!");
                    if (record._entries.Count == 0)
                    {
                        Console.WriteLine("No entries found. Start writing your journal first!");
                    }
                    else
                    {
                        record.DisplayAll();
                    }
                    break;

                case "3":
                    Console.WriteLine("You chose to Load!");
                    Console.WriteLine("What is the filename?");
                    string filenameToLoad = Console.ReadLine();
                    record.LoadFromFile(filenameToLoad);

                    if (record._entries.Count > 0)
                    {
                        Console.WriteLine("\nLoaded Entries:");
                        record.DisplayAll(); // Show all loaded entries
                    }
                    else
                    {
                        Console.WriteLine("No entries were loaded. The file might be empty.");
                    }
                    break;

                case "4":
                    Console.WriteLine("You chose to Save!");
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    record.SaveToFile(filename);
                    break;

                case "5":
                    Console.WriteLine("You chose to Quit. Goodbye!");
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (!exitProgram); // Loop until exitProgram is true

    }
}