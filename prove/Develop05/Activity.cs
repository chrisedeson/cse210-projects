using System;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nStarting the {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds. Well done!");
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds + " ");
            System.Threading.Thread.Sleep(1000);
            seconds--;
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int durationInSeconds)
    {
        string[] spinnerFrames = { "|", "/", "——", "\\" };
        int frameIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinnerFrames[frameIndex]} ");
            frameIndex = (frameIndex + 1) % spinnerFrames.Length;
            System.Threading.Thread.Sleep(200); // Adjust speed of spinner here
        }
        Console.Write("\r   \r"); // Clear spinner
    }

    public int GetDuration() => _duration;
}
