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

                var dayinput = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);

                Console.WriteLine("It is {0}", day);
            }
                //Console.WriteLine("Please enter an actual day of the week.");
                
                //var day = Console.ReadLine();
                //string[] values = Enum.GetNames(typeof(DaysOfTheWeek));//creates a 1D array to store enum values
                //for ( int i = 0; i < 7; i++)
                //{
                    
                    //if (day == values[i])
                    //{
                      //  Console.WriteLine((DaysOfTheWeek)i);//outputs the string value of the enum
                        //int intvalue = (int)(DaysOfTheWeek)i;//converts enum to int value for the specific day
                        //Console.WriteLine("That day has a Enum value of " + intvalue);//outputs the int value of the enum
                         
                    //}
                    //else if (i == 6)
                    //{
                    //    throw new ArgumentException();//I think this will throw an exception that the catch will catch?
                    //}
                //}
        
            
            catch (ArgumentException ex)//catches any exceptions
            {
                Console.WriteLine("Please insert a valid day.");
            }

            Console.ReadLine();
            
        
        
        
        }
         
    }
}
