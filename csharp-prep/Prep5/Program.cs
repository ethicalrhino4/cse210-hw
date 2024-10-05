using System;

class Program
{
    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Function to prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    // Function to square the user's number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the final result using the user's name and squared number
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

    // Main function where everything ties together
    static void Main(string[] args)
    {
        // Call each function in the correct order
        DisplayWelcome();  // Display the welcome message

        string userName = PromptUserName();  // Get the user's name
        int favoriteNumber = PromptUserNumber();  // Get the user's favorite number

        int squaredNumber = SquareNumber(favoriteNumber);  // Square the favorite number

        DisplayResult(userName, squaredNumber);  // Display the result with the user's name
    }
}
