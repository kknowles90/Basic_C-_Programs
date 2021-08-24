using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObject
{
    public class Employee : Person, IQuittable //inherits from person class
    {
        
        public int Id { get; set; }

        public override void SayName()//uses Person.SayName as base
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);//outputs example Name: FirstName LastName
            Console.ReadLine();//to see if it was called
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Calling interface");
            Console.ReadLine();
        }


    }
}


