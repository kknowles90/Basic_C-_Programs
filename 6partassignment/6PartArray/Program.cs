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
            //Part 1
            Console.WriteLine("Please insert a sentence or a string");
            var initialString = Console.ReadLine();
            var words = initialString.Split(' ');
            for (int i = 0; i < initialString.Length; i++)
            {
                Console.WriteLine(words[i]);
             
            }
            Console.ReadLine();


            //Part 2 infinite loop, to fix just remove j +
            //Leave the 1 for 1 loop or change it to any int for that many loops
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("This is an infinite loop");
                Console.ReadLine();
                
                
            }

            //Part 3
            //I am a little unsure what the question is asking but here are two loops that should cover it
            for (int h = 0; h < 5; h++)
            {
                Console.WriteLine("this is the " + h + "th loop");
            }
            Console.ReadLine();

            for (int k = 0; k <= 5; k++)
            {
                if (k == 5)
                {
                    Console.WriteLine("this is the last loop");
                }
                else
                {
                    Console.WriteLine("this is the " + k + "th loop");
                }
            }
            Console.ReadLine();

            Console.WriteLine("Enter items to be inputted to a list");

            Console.WriteLine("Input one of your courses here:");
            string incourse = Console.ReadLine();
            List<string> coursesUCF = new List<string>() { "vibrations", "aerodynamics", "modeling", "measurements" };

            foreach (string name in coursesUCF)//filters each one to determine the matched outcome
            {
                if (incourse == "vibrations")
                {

                    Console.WriteLine("You have choosen vibrations");
                    Console.ReadLine();
                    break;//breaks cycle once match found
                }

                else if (incourse == "aerodynamics")
                {
                    Console.WriteLine("You have choosen aerodynamics");
                    Console.ReadLine();
                    break;
                }

                else if (incourse == "modeling")
                {
                    Console.WriteLine("You have choosen modeling");
                    Console.ReadLine();
                    break;
                }

                else if(incourse == "measurements")
                {
                    Console.WriteLine("You have choosen measurements");
                    Console.ReadLine();
                    break;
                }

                else
                {
                    Console.WriteLine("You have not choosen a valid name");
                    Console.ReadLine();
                    break;
                }

                
            }

        }
    }
}
