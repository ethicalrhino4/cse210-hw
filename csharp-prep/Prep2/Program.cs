using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking for user's grade percentage
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        // Variable to store the letter grade
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Add a sign for grades except F
        if (letter != "F")
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle exceptions for A+ and F+/F-
        if (letter == "A" && sign == "+")
        {
            sign = "";  // No A+
        }
        else if (letter == "F")
        {
            sign = "";  // No F+ or F-
        }

        // Print the letter grade with the sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Check if the student passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, try again next time.");
        }
    }
}
