using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //First video
        Video video1 = new Video("How train your dog", "Pinscher", 587);
        video1.Comments.Add(new Comment("Alice", "Soo cute!"));
        video1.Comments.Add(new Comment("Spongebob", "Now i know how help my puppy."));
        video1.Comments.Add(new Comment("Charlie", "That work with bigger dogs??"));
        videos.Add(video1);

        //Second video
        Video video2 = new Video("Video editing", "Editor-3000", 360);
        video2.Comments.Add(new Comment("Dan", "Thank you!"));
        video2.Comments.Add(new Comment("Eliza", "Can you did a tutorial about VFX?"));
        video2.Comments.Add(new Comment("Roy", "That fade effect is awasome!"));
        videos.Add(video2);

        //Third video
        Video video3 = new Video("Tracking your health", "Personality", 540);
        video3.Comments.Add(new Comment("Gina", "I love it."));
        video3.Comments.Add(new Comment("Hannah", "Can you share your workout schedule?"));
        video3.Comments.Add(new Comment("Ivan", "It's a wonderful starting point."));
        videos.Add(video3);
        
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}