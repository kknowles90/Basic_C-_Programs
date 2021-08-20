using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Methods
    {
        public int Method1(int var)//method1 runs and returns var + 12
        {
            int total1 = var + 12;
            return total1;
        }

        public int Method2(int var2)//method2 takes total1 and returns total1 / 2
        {
            int total2 = var2 / 2;
            return total2;
        }

        public int Method3(int var3)//method3 takes in total2 and returns total2 * 10
        {
            int total3 = var3 * 10;
            return total3;
        }
    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("Insert an interger to be added by 12, divided by 2, and multiplied by 10:");
            int num = Convert.ToInt32(Console.ReadLine());

            Methods n = new Methods();//calls first method and returns total
            int total1 = n.Method1(num);
            Console.WriteLine(total1);

            int total2 = n.Method2(total1);//calls and returns second total
            Console.WriteLine(total2);

            int total3 = n.Method3(total2);//calls and returns method 3 total.
           

            Console.WriteLine("Your answer is: " + total3);
            Console.ReadLine();

        }
    }
}
