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
                    Console.WriteLine(inputint / num);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }


            
        }
    }
}
