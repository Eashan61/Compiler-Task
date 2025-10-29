using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class WordCounter
    {
        static void Main(string[] args)
        {
            // Variable to track the number of words entered
            int wordCount = 0;

            // Variable to hold the user's current input
            string inputWord = "";

            Console.WriteLine("--- Word Entry Tool ---");
            Console.WriteLine("Start entering words below. Type 'exit' (case-insensitive) to stop and see the total count.");

            // We use a 'while (true)' loop (an infinite loop) and an internal 'break' 
            // controlled by the sentinel value ("exit") to ensure we always read input.
            while (true)
            {
                Console.Write("\nEnter word: ");
                inputWord = Console.ReadLine();

                // Check if the input matches the sentinel value "exit" (case-insensitive)
                if (inputWord.Trim().ToLower() == "exit")
                {
                    Console.WriteLine("\n'exit' detected. Stopping word count.");
                    break; // Exit the while loop
                }

                // If it's not "exit", increment the counter
                wordCount++;
            }

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"Final tally: You entered a total of {wordCount} words.");
            Console.WriteLine("-------------------------------------");
        }
    
    }
}
