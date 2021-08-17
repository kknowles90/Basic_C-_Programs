using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //do while statement using the guessing of a number input and output
            Console.WriteLine("Guess a number between 1 and 10? \n hint: the answer is 1");
            string guess = Console.ReadLine();
            int guess1 = Convert.ToInt32(guess);
            bool isGuess = false;

            do
            {
                switch (guess1)
                {
                    case 1:
                        Console.WriteLine("You have guessed right!");
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong, guess again:");
                        guess1 = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuess);
            Console.ReadLine();

            //regular while loop
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("This is line " + i + " out of 3");
                i++;
                Console.ReadLine();
            }
        }
    }
}
