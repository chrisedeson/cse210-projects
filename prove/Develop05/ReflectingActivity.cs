using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;

    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience.",
               0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a significant challenge.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you accomplished something you were proud of."
        };
    }

    public void Run()
{
    DisplayStartingMessage();
    string prompt = GetRandomPrompt();
    Console.WriteLine("\nReflect on the following prompt:");
    Console.WriteLine(prompt);
    ShowSpinner(5); // Replace countdown with spinner

    Console.WriteLine("\nConsider why this experience was meaningful to you.");
    ShowSpinner(GetDuration()); // Replace countdown with spinner

    DisplayEndingMessage();
}


    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
