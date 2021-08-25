using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObject
{
    public class Program
    {
        static void Main(string[] args)
        {


            Employee a = new Employee() { Id = 1, name = "person1"};
            Employee b = new Employee() { Id = 1, name = "person1" };
            //a.Equals(b);
            a == b;//this would also work.
            //IQuittable Quitter = new Employee();
            //Person.FirstName = "Sample";
            //Person.LastName = "Student";
            //Person.SayName();//Calls method SayName from Person class
            //Person.SayName();

            //Quitter.Quit("Mark");
            Console.ReadLine();
            

        }

        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        //DaysOfTheWeek day = DaysOfTheWeek.
    }
}
