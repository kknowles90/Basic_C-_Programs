using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            Employee num1 = new Employee("Joe", "Smow", 1);
            Employee num2 = new Employee("Joe", "Biden", 2);
            Employee num3 = new Employee("Kyle", "Lawerance", 3);
            Employee num4 = new Employee("Samantha", "Emily", 4);
            Employee num5 = new Employee("John", "Snow", 5);
            Employee num6 = new Employee("Donald", "Trump", 6);
            Employee num7 = new Employee("Adam", "Sandler", 7);
            Employee num8 = new Employee("Alex", "Ronalds", 8);
            Employee num9 = new Employee("Johnny", "Cash", 9);
            Employee num10 = new Employee("Malcom", "Smith", 10);

            empList.Add(num1);
            empList.Add(num2);
            empList.Add(num3);
            empList.Add(num4);
            empList.Add(num5);
            empList.Add(num6);
            empList.Add(num7);
            empList.Add(num8);
            empList.Add(num9);
            empList.Add(num10);

            

            foreach (Employee emp in empList)
            {
                var fname = emp.firstName;
                var lname = emp.lastName;
                var ID = emp.ID;
                
                if (emp.firstName == "Joe")
                {
                    List<Employee> nameList = new List<Employee>();
                    Employee matchName = new Employee(fname, lname, ID);
                    nameList.Add(matchName);
                    //Console.WriteLine(fname, lname, ID);
                }
            }
            
            List<Employee> newlist = empList.Where(x => x.firstName == "Joe").ToList();

            List<Employee> numlist = empList.Where(x => x.ID > 5).ToList();
            
            Console.ReadLine();
        }
    }
}
    


            


        
        //In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.At least two employees should have the first name “Joe”.


        //Using a foreach loop, create a new list of all employees with the first name “Joe”.

//Perform the same action again, but this time with a lambda expression.

//Using a lambda expression, make a list of all employees with an Id number greater than 5.


