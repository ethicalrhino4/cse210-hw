using System;

namespace MindfulnessApp.Activities
{
    public class ReflectionActivity : Activity
    {
        private static string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
        {
        }

        public void Start()
        {
            ShowStartingMessage();
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Pause(3); // Pause for 3 seconds

            int duration = Duration;
            int totalTime = 0;

            while (totalTime < duration)
            {
                string question = questions[random.Next(questions.Length)];
                Console.WriteLine(question);
                Pause(4); // Pause for 4 seconds
                totalTime += 4;
            }

            ShowEndingMessage();
        }
    }
}