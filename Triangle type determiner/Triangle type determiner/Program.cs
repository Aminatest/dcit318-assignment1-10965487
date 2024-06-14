using System;

namespace TriangleTypeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the three sides
            Console.Write("Enter the length of side 1: ");
            double side1 = GetValidSide();

            Console.Write("Enter the length of side 2: ");
            double side2 = GetValidSide();

            Console.Write("Enter the length of side 3: ");
            double side3 = GetValidSide();

            // Determine the type of the triangle
            string triangleType = DetermineTriangleType(side1, side2, side3);

            // Display the result
            Console.WriteLine($"The triangle is {triangleType}");
        }

        // Method to read and validate side length input
        static double GetValidSide()
        {
            while (true)
            {
                try
                {
                    double side = Convert.ToDouble(Console.ReadLine());
                    if (side > 0)
                    {
                        return side;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a positive number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
        }

        // Method to determine the type of triangle
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}

