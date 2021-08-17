using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //input and output for age, as well as data change
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);

            //input and output for dui boolean
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool dui1 = Convert.ToBoolean(dui);

            //input and output for speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            int speeding1 = Convert.ToInt32(speeding);

            //comparisions
            bool qualified = (age1 >= 16 && dui1 == false && speeding1 < 4);
            Console.WriteLine(qualified);
            Console.ReadLine();


        }
    }
}
