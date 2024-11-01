// Program.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Testing Assignment base class
        Assignment generalAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(generalAssignment.GetSummary());

        // Testing MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Testing WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
