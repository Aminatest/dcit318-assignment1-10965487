using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            // Validate the input and calculate the ticket price
            try
            {
                int age = Convert.ToInt32(input);

                // Determine the ticket price based on age
                int ticketPrice = CalculateTicketPrice(age);

                // Display the ticket price
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid age.");
            }
        }

        // Method to calculate ticket price based on age
        static int CalculateTicketPrice(int age)
        {
            const int regularPrice = 10;
            const int discountedPrice = 7;

            if (age <= 12 || age >= 65)
            {
                return discountedPrice;
            }
            else
            {
                return regularPrice;
            }
        }
    }
}
