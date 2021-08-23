using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Methods
    {
        public int Method1(int var1, int var2 = 10)//method1 runs and returns var + 12
        {

            int total1 = var1 + 12 + var2;
            return total1;
        }

 
    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("Insert one or two integers:");
            Console.WriteLine("It is optional to enter a second integer:");
            int var1 = Convert.ToInt32(Console.ReadLine());
            var opt = Console.ReadLine();
     
           
            //Console.WriteLine("(Optional) Insert a second integer:");
            
            Methods n = new Methods();//calls first method and returns total
            
            if (opt != "")
            {
                int optionalvar2 = Convert.ToInt32(opt);
                int total1 = n.Method1(var1, optionalvar2);
                Console.WriteLine(total1);
            }
            else
            {
                int total1 = n.Method1(var1);
                Console.WriteLine(total1);
            }
                    

            Console.ReadLine();
        }
    }
}
