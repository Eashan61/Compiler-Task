using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Nested
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("--- Number Analyzer ---");
            Console.Write("Enter a whole number: ");

            string input = Console.ReadLine();

            // Safely try to convert the string input to an integer
            if (int.TryParse(input, out int number))
            {
                // --- OUTER IF-ELSE IF-ELSE: Check the sign (Positive, Negative, or Zero) ---

                if (number > 0)
                {
                    Console.Write($"The number {number} is positive and ");

                    // --- NESTED IF-ELSE: Check for Even or Odd (only if positive) ---
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("it is even.");
                    }
                    else
                    {
                        Console.WriteLine("it is odd.");
                    }
                }
                else if (number < 0)
                {
                    Console.Write($"The number {number} is negative and ");

                    // --- NESTED IF-ELSE: Check for Even or Odd (only if negative) ---
                    // We use the absolute value to ensure consistent even/odd check
                    if (Math.Abs(number) % 2 == 0)
                    {
                        Console.WriteLine("it is even.");
                    }
                    else
                    {
                        Console.WriteLine("it is odd.");
                    }
                }
                else // number == 0
                {
                    // Zero is a special case (neither positive nor negative, and is even)
                    Console.WriteLine("The number is zero (0). It is considered even.");
                }
            }
            else
            {
                // Handling case where input is not a valid number (e.g., "hello")
                Console.WriteLine("Invalid Input: Please enter a valid whole number.");
            }
        }
    }
}
