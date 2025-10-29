using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class @switch
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter day number!");

            int dayNo;

            dayNo = int.Parse(Console.ReadLine());

            switch (dayNo)
            {

                case 1:

                    Console.WriteLine("Sunday");

                    break;

                    case 2:

                    Console.WriteLine("Monday");

                    break;

                    case 3:

                    Console.WriteLine("Tuesday");
                    break;

                    case 4:

                    Console.WriteLine("Wednesday");
                    break;

                    case 5:
                    Console.WriteLine("Thrusday");
                    break;

                    default:
                    Console.WriteLine("No Day Found!");
                    break;


            }
        }
    }
}
