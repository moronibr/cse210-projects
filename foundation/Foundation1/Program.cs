using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# in 10 Minutes", "Moroni Bamvakiades Ramos", 600);
        Video video2 = new Video("Advanced C# Programming", "Moroni Bamvakiades Ramos", 1800);
        Video video3 = new Video("C# Design Patterns", "Moroni Bamvakiades Ramos", 1200);

        video1.AddComment(new Comment("Cora", "Great tutorial, very helpful!"));
        video1.AddComment(new Comment("Rebeca", "Thanks for the video!"));
        video1.AddComment(new Comment("Jarede", "Can you make a video on LINQ?"));

        video2.AddComment(new Comment("Rebeca", "This is exactly what I needed!"));
        video2.AddComment(new Comment("Cora", "Very detailed and well explained."));
        video2.AddComment(new Comment("Eduardo(Dudu)", "I learned a lot, thank you!"));

        video3.AddComment(new Comment("Jarede", "Design patterns simplified!"));
        video3.AddComment(new Comment("Eduardo(Dudu)", "Excellent examples and explanations."));
        video3.AddComment(new Comment("Mariana", "Looking forward to more videos like this."));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

       
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
