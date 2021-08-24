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
            Monday,//0
            Tuesday,//1
            Wednesday,//2
            Thursday,//3
            Friday,//4
            Saturday,//5
            Sunday//6
        }
        static void Main(string[] args)
        {
 
            try
            {
                Console.WriteLine("Please enter an actual day of the week.");
                
                var day = Console.ReadLine();
                string[] values = Enum.GetNames(typeof(DaysOfTheWeek));//creates a 1D array to store enum values
                for ( int i = 0; i < 6; i++)
                {
                    var wd = (DaysOfTheWeek)i;
                    if (day == values[i])
                    {
                        Console.WriteLine((DaysOfTheWeek)i);//outputs the string value of the enum
                        int intvalue = (int)(DaysOfTheWeek)i;//converts enum to int value for the specific day
                        Console.WriteLine("That day has a Enum value of " + intvalue);//outputs the int value of the enum
                         
                    }
                }
        
            }
            catch (Exception ex)//catches any exceptions
            {
                Console.WriteLine("Please insert a valid day.");
            }

            Console.ReadLine();
            
        
        
        
        }
         
    }
}
