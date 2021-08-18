using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartArray
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> newList = new List<string>() { "dog", "cat", "bunny", "fish", "horse", "goat", "horse" };
            Console.WriteLine("Please enter an animal from the list");
            string inputanimal = Console.ReadLine();

            int i = 0;
            foreach (string name in newList)
            {
                if (inputanimal == name)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else
                {
                    i++;
                }
            }


            

        }
    }
}