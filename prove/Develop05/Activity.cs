using System;

namespace MindfulnessApp.Activities
{
    public class Activity
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Duration { get; set; }

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void SetDuration(int seconds)
        {
            Duration = seconds;
        }

        public void ShowStartingMessage()
        {
            Console.WriteLine($"Starting {Name}...");
            Console.WriteLine(Description);
            Console.WriteLine("Please prepare to begin.");
            Pause(3); // Pause for 3 seconds
        }

        public void ShowEndingMessage()
        {
            Console.WriteLine("Good job! You've completed the activity.");
            Console.WriteLine($"Activity: {Name}");
            Console.WriteLine($"Duration: {Duration} seconds");
            Pause(3); // Pause for 3 seconds
        }

        protected void Pause(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000); // Pause for specified seconds
        }
    }
}