using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObject
{
    public class Employee : Person //IQuittable //inherits from person class
    {
        
        public int Id { get; set; }
        public string name { get; set; }



        //public override void SayName()//uses Person.SayName as base
        //{
        //Console.WriteLine("Name: " + FirstName + " " + LastName);//outputs example Name: FirstName LastName
        //Console.ReadLine();//to see if it was called
        //base.SayName();
        //}

        //public void Quit(string FirstName)
        //{
        //  Console.WriteLine("This is working");
        //}

        //public static Employee operator== (Employee Id, Person LastName)
        //{
        //    Id.LastName.Equals(LastName);//sets LastName and Id to equal if == operator is used.
        //    return Id;
        //}

        //public static Employee operator!= (Employee Id, Person LastName)//if != is used, it will be considered null
        //{
        //    return null;
        //}


        public static bool operator ==(Employee a, Employee b)
        {
            if (System.Object.ReferenceEquals(a, b))
                return true;

            if ((object)a == null || (object)b == null)
                return false;

            return a.Id == b.Id && a.name == b.name;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !(a == b);
        }


    }
}




