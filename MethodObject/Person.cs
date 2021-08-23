using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()//superclass being called
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);//outputs example Name: FirstName LastName
            Console.ReadLine();//to see if it was called
        }
    }
}
