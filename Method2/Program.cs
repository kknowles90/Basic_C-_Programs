using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Methods
    {
        public int Method1(int var)//method1 runs and returns var + 12
        {
            int total1 = var + 12;
            return total1;
        }

        public int Deci(decimal var2)//takes in a decimal, output is an int
        {

            var2 = var2 + 12;
            int total2 = Convert.ToInt32(var2);
            return total2;
        }

        public int Strin(string var3)// takes in a string and converts to int if possible
        {
            try
            {
                
                int total3 = Convert.ToInt32(var3) + 12;
                return total3;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("Insert an integer to be added by 12, divided by 2, and multiplied by 10:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a decimal to be converted to interger: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insert an integer:");
            string var3 = Console.ReadLine(); 
            
            Methods n = new Methods();//calls first method and returns total
            int total1 = n.Method1(num);
            Console.WriteLine(total1);

            int total2 = Convert.ToInt32(n.Deci(num2));//calls Deci method
            Console.WriteLine(total2);

            int total3 = n.Strin(var3);//calls string to int method
            Console.WriteLine(total3);

            Console.ReadLine();





        }
    }
}
