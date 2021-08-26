using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//The current time displayed as output
            Console.WriteLine("Insert an amount of hours to be added to the current date:");
            int x = Convert.ToInt32(Console.ReadLine());
            DateTime current = DateTime.Now;
            DateTime hours = current.AddHours(x);//The inputted hours from user
            Console.WriteLine("The requested time would be: " + hours);// the output would be in the form of "The requested time would be: (time inserted here)"
            Console.ReadLine();
            
        }
    }
}
