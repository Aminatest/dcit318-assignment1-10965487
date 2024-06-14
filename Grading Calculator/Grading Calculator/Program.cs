using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Prompt the user to enter a numerical grade
                    Console.Write("Enter a numerical grade between 0 and 100: ");
                    string input = Console.ReadLine();

                    // Convert the input to a double
                    double numericGrade = Convert.ToDouble(input);

                    // Check if the input is within the valid range
                    if (numericGrade >= 0 && numericGrade <= 100)
                    {
                        // Get the letter grade
                        string letterGrade = GetLetterGrade(numericGrade);
                        // Display the result
                        Console.WriteLine($"The letter grade is: {letterGrade}");
                        break; // Exit the loop after successful input
                    }
                    else
                    {
                        Console.WriteLine("Error: The grade must be between 0 and 100. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid numerical grade. For example, 85 or 92.5.");
                }
            }
        }

        // Function to determine letter grade
        static string GetLetterGrade(double numericGrade)
        {
            if (numericGrade >= 90)
            {
                return "A";
            }
            else if (numericGrade >= 80)
            {
                return "B";
            }
            else if (numericGrade >= 70)
            {
                return "C";
            }
            else if (numericGrade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}

