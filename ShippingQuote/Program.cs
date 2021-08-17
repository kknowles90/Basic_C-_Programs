using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather all input and output and change to int.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of the package in pounds:");
            string sweight = Console.ReadLine();
            Console.WriteLine("What is the height of the package in feet:");
            string sheight = Console.ReadLine();
            Console.WriteLine("What is the length of the package in feet:");
            string slength = Console.ReadLine();
            Console.WriteLine("What is the width of the package in feet:");
            string swidth = Console.ReadLine();
            int iweight = Convert.ToInt32(sweight);
            int iwidth = Convert.ToInt32(swidth);
            int ilength = Convert.ToInt32(slength);
            int iheight = Convert.ToInt32(sheight);

            //if statements and comparisions
            int total = iheight + iwidth + ilength;
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else if (iweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                float estimatedTotal = (iweight * iheight * ilength * iwidth) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + estimatedTotal);
                Console.WriteLine("Thank You!");
                Console.ReadLine();
            } 
        }
    }
}
