using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{

    public static class statclass
     {
        //a class for static emembers, can't be instantiated, is sealed, and cannont contain instance constructors.
     }


    class Methods
    {
        public void Method1(int num)//method1 runs and divides data by 2 and outputs
        {
            int total1 = num / 2;
            Console.WriteLine(total1);
            return;
            
        }

        public int Method1(int num, int num2 = 2)//overload method1 with output parameters of int
        {

            int total1 = num / num2;
            //Not sure what else you want me to put in overloaded method.
            Console.WriteLine(total1);
            return total1;
        }


    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("Insert an integer to be divided by 2:");
            int num = Convert.ToInt32(Console.ReadLine());

            Methods n = new Methods();

            n.Method1(num);
            
            
            
            //Console.WriteLine(total1);

 

            Console.ReadLine();





        }
    }
}
