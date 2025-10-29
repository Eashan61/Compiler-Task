using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class age
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Please enter your age!");

            string ageString = Console.ReadLine();
            
            int ageInt = int.Parse(ageString);

            Console.WriteLine($"You entered : {ageInt}");

            if(ageInt < 18 ){

                Console.WriteLine($"You are a minor!");
            } else if(ageInt > 18)
            {
                Console.WriteLine("You are a adult!");
            }
            else if (ageInt > 60)
            {
                Console.WriteLine("You are a senior cetizen!");
            }


        }
    }
}
