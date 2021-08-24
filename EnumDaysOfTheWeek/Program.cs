using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDaysOfTheWeek
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
 
            try
            {
                Console.WriteLine("Please enter an actual day of the week.");
                string day = Console.ReadLine();
                for ( int i = 0; i < 6; i++)
                {
                    if (day == DaysOfTheWeek.[i])
                    {
                        Console.WriteLine(DaysOfTheWeek.[i]);
                    }
                }
        
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please insert a valid day.");
            }

            Console.ReadLine();
        
        
        
        }
         
    }
}
