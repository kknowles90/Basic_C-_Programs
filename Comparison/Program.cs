using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //details for person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 : Hourly Rate");
            string hour1 = Console.ReadLine();
            Console.WriteLine("Person 1 : Hours worked per week");
            string hoursworked = Console.ReadLine();

            //details for person 2
            Console.WriteLine("Person 2 : Hourly Rate");
            string hour2 = Console.ReadLine();
            Console.WriteLine("Person 2 : Hours worked per week");
            string hours2worked = Console.ReadLine();

            //converting string to int and computing for annual for p1
            int person1rate = Convert.ToInt32(hour1);
            int person1worked = Convert.ToInt32(hoursworked);
            int annual1 = person1rate * person1worked * 52;
            Console.WriteLine("Annual salary of Person 1:" + annual1);
            Console.ReadLine();

            //converting string to int and computing for annual for p2
            int person2rate = Convert.ToInt32(hour2);
            int person2worked = Convert.ToInt32(hours2worked);
            int annual2 = person2rate * person1worked * 52;
            Console.WriteLine("Annual salary of Person 2:" + annual2);
            Console.ReadLine();

            //comparision between p1 and p2
            bool p1andp2 = annual1 > annual2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1andp2);
            Console.ReadLine();




        }
    }
}
