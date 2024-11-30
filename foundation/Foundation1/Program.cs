using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("C# Basics Tutorial", "Christopher Edeson", 600);
        Video video2 = new Video("Advanced Programming technique", "Jane Lamba", 2000);
        Video video3 = new Video("How to Drink Water", "Joy Chukwu", 20);

        // Comments for video 1
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "How do you create variable Sir?"));
        video1.AddComment(new Comment("Charlie", "Can you cover more examples?"));

        // Comments for video 2
        video2.AddComment(new Comment("Ade", "Fantastic Content!"));
        video2.AddComment(new Comment("Chris", "I have trouble setting it up"));
        video2.AddComment(new Comment("Bola Muhammed", "lol"));

        // Comments for video 3
        video3.AddComment(new Comment("Daniel", "Thank you making this video"));
        video3.AddComment(new Comment("Alaba", "you saved my life"));
        video3.AddComment(new Comment("Ian", "I still don't know how, someone please help"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine();
        }


    }
}