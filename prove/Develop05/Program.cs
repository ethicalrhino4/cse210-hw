using System;
using MindfulnessApp.Activities;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindfulness App!");
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();
                if (choice == "4") break;

                Console.WriteLine("Enter the duration of the activity in seconds:");
                if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
                {
                    Console.WriteLine("Please enter a valid positive number.");
                    continue;
                }

                Activity activity = null;
                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        continue;
                }

                activity.SetDuration(duration);
                if (activity is BreathingActivity breathingActivity)
                {
                    breathingActivity.Start();
                }
                else if (activity is ReflectionActivity reflectionActivity)
                {
                    reflectionActivity.Start();
                }
                else if (activity is ListingActivity listingActivity)
                {
                    listingActivity.Start();
                }
            }
        }
    }
}