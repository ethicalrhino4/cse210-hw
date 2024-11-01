using System;

namespace MindfulnessApp.Activities
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.")
        {
        }

        public void Start()
        {
            ShowStartingMessage();
            Console.WriteLine("Let's begin the breathing exercise.");

            int duration = Duration;

            for (int i = 0; i < duration; i += 4) // Assume breathing exercise lasts for the specified duration
            {
                Console.WriteLine("Breathe in...");
                Pause(4); // Pause for 4 seconds
                Console.WriteLine("Breathe out...");
                Pause(4); // Pause for 4 seconds
            }

            ShowEndingMessage();
        }
    }
}