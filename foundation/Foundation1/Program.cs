using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; } = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        // Creating 3-4 videos and setting properties
        Video video1 = new Video("Introduction to Programming", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great introduction!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Looking forward to more videos!"));

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 450);
        video2.AddComment(new Comment("Diana", "This is exactly what I needed."));
        video2.AddComment(new Comment("Eve", "Clear explanations, thank you!"));
        video2.AddComment(new Comment("Frank", "More examples would be nice."));

        Video video3 = new Video("Database Management Basics", "James Brown", 600);
        video3.AddComment(new Comment("Grace", "A lot of info packed in here!"));
        video3.AddComment(new Comment("Hannah", "Would love a follow-up on this."));
        video3.AddComment(new Comment("Ian", "Thanks for the insights."));

        // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying each video's details and comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
