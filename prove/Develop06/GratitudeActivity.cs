using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity()
        : base("Gratitude Activity",
               "This activity will help you reflect on the things you are grateful for, fostering a positive mindset.",
               0)
    {
        _prompts = new List<string>
        {
            "What are you grateful for in your personal life?",
            "Who are the people you are grateful for and why?",
            "What abilities or talents are you thankful for?",
            "What opportunities are you grateful to have experienced?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nThink about the following prompt:");
        Console.WriteLine(prompt);
        ShowSpinner(5); // Spinner replaces countdown

        List<string> gratitudeItems = new List<string>();
        Console.WriteLine("List the things you're grateful for. Press 'Enter' after each. Type 'done' to finish.");
        string input;
        do
        {
            Console.Write(">> ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.ToLower() != "done")
            {
                gratitudeItems.Add(input);
            }
        } while (input.ToLower() != "done");

        Console.WriteLine($"\nYou listed {gratitudeItems.Count} things you're grateful for:");
        foreach (string item in gratitudeItems)
        {
            Console.WriteLine($"- {item}");
        }

        DisplayEndingMessage();
    }


    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
