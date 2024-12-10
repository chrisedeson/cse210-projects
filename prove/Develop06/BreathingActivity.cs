using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding you through slow, deep breaths. Clear your mind and focus on your breathing.",
               0)
    { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int cycle = duration / 6;

        for (int i = 0; i < cycle; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);  // Countdown is retained here with seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);  // Countdown is retained here with seconds
        }

        DisplayEndingMessage();
    }
}
