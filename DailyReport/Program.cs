using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Tech Academy \nStudent Daily Report.");
            Console.WriteLine("What is your name?");//writes output
            string name = Console.ReadLine();//reads input and stores it as a string under "name"
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pnumber = Console.ReadLine();
            int page = Convert.ToInt32(pnumber);//converts string to int for page number
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            bool helpneeded = Convert.ToBoolean(help);//converts string to boolean to save space
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posexpience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursstudy = Console.ReadLine();
            int study = Convert.ToUInt16(hoursstudy); //converts string to int for hours of study

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            //End of program

        }
    }
}
