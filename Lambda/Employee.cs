using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Employee
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public double ID { get; set; }

        public Employee(string firstName, string lastName, double ID)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.ID = ID;
        }
    }
}
