using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> divideby = new List<int>() { 1, 2, 3, 4, 5 };
                Console.WriteLine("Enter a whole number to be divided by");
                int inputint = Convert.ToInt32(Console.ReadLine());
                foreach (int num in divideby)
                {
                    Console.WriteLine(num / inputint);
                }
            }
            catch (FormatException ex)//invalid format exception such as inserting a string or character
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)//invalid divide by 0 exception which would require list change
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)//all other exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally//finally statement mainly used for creating an error log
            {
                Console.ReadLine();
            }


            
        }
    }
}
