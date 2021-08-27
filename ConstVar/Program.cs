using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            const string example = "This is a constant string";//Creates a constant variable under example

            var example2 = "this is a variable";//creates a var called example2

            Student student = new Student("102", "Adam Smith");//Calls the constructor from constructors.cs with two inputs
            

        }
    }
}
