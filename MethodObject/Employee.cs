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

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
                return true;
            else
                return false;

            //but you should use 
            //return employee.ID == employee2.ID;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }

        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.Id.Equals(emp.Id);
        }


    }
}




