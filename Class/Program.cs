using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    static class Methods
    {
        public static void Method1(int num)//method1 runs and divides data by 2 and outputs
        {
            int total1 = num / 2;
            Console.WriteLine(total1);
            return;
            
        }

        public static int Metho1(int num2, int num3)//overload method1 with output parameters of int
        {
            num2 = 5;
            num3 = 6;
            //Not sure what else you want me to put in overloaded method.
            return 0;
        }


    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("Insert an integer to be divided by 2:");
            int num = Convert.ToInt32(Console.ReadLine());


            Methods.Method1(num);
            
            
            
            //Console.WriteLine(total1);

 

            Console.ReadLine();





        }
    }
}
