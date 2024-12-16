using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the positive aspects of your life by listing as many things as you can in a certain area.",
               0)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths you have?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Spirit this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nList as many things as you can for the following prompt:");
        Console.WriteLine(prompt);
        ShowSpinner(5); // Spinner replaces countdown

        List<string> responses = new List<string>();
        Console.WriteLine("Start listing. Press Enter after each item. Type 'done' to finish.");
        string input;
        do
        {
            Console.Write(">> ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.ToLower() != "done")
            {
                responses.Add(input);
            }
        } while (input.ToLower() != "done");

        Console.WriteLine($"\nYou listed {responses.Count} items. Great job!");
        DisplayEndingMessage();
    }


    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
