using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class program
    {
        static void Main()
        {
            Console.WriteLine("Insert number 1:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert number 2:");
            double y = Convert.ToDouble(Console.ReadLine());

            


            void method1(double var1, double var2)//takes in two double data points and does a math operation to var1 and prints var2
            {

                var1 = 12 + var2 + var1;
                Console.WriteLine(var2);

            }

            method1(var1: x, var2: y);

            //Methods n = new Methods();//calls first method
            //n.method1(num, num2);

            Console.ReadLine();

        }
    }
}
