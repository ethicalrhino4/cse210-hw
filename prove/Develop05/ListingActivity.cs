using System;

namespace MindfulnessApp.Activities
{
    public class ListingActivity : Activity
    {
        private static string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
        {
        }

        public void Start()
        {
            ShowStartingMessage();
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Pause(3); // Pause for 3 seconds

            Console.WriteLine("You can start listing now. Press Enter after each item.");
            string input;
            int itemCount = 0;
            int duration = Duration;

            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                input = Console.ReadLine();
                itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items.");
            ShowEndingMessage();
        }
    }
}