using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fortune Teller: Let me tell you your fortune");
            Console.WriteLine("Please enter your first name.");

            string first = (Console.ReadLine());

            Console.WriteLine("Please enter your last name.");

            string last = (Console.ReadLine());

            Console.WriteLine("Please enter your age.");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birth month from 1 to 12.");

            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite ROYGBIV color.");
            Console.WriteLine("If you do not know what ROYGBIV is, please enter \"Help\" to get a list of the ROYGBIV colors.");

            string color = (Console.ReadLine());

            if (color.ToLower() == "help")
            {
                Console.WriteLine("R = Red");
                Console.WriteLine("O = Orange");
                Console.WriteLine("Y = Yellow");
                Console.WriteLine("G = Green");
                Console.WriteLine("B = Blue");
                Console.WriteLine("I = Indigo");
                Console.WriteLine("V = Violet");
                Console.WriteLine("Again, please enter your favorite ROYGBIV color.");
                string colorAfter = (Console.ReadLine());
            }

            Console.WriteLine("Please enter the number of siblings you have.");

            int siblings = int.Parse(Console.ReadLine());
        }
    }
}
