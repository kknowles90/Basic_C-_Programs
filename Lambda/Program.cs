using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee
    {
        public static void Main(string[] args)
        {
        public String lastName { get; set; }
        public String firstName { get; set; }
        public double ID { get; set; }

        public Employee(String firstName, String lastName, double ID)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.ID = ID;
        }

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

        foreach (String Name in firstName)
        {

        }

        //In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.At least two employees should have the first name “Joe”.


        //Using a foreach loop, create a new list of all employees with the first name “Joe”.
    }
}

