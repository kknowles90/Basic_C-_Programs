using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sArray = { "This", "Is", "An", "Array" };//creates string array
            Console.WriteLine("Pick an index for the string array");
            int i = Convert.ToInt32(Console.ReadLine());//converts input to int

            int[] iArray = { 5, 6, 10, 11, 14 };
            Console.WriteLine("Pick an index for the int array");
            int j = Convert.ToInt32(Console.ReadLine());//converts input to int

            List<string> StriList = new List<string>() { "This", "Is", "A", "String" };
            StriList.Add("List");
            Console.WriteLine("Pick an index for the string list");
            int k = Convert.ToInt32(Console.ReadLine());



            if (i >= 5 || j >= 5 || k >= 5)
            {
                Console.WriteLine("invalid index number. Please enter a number less than 5");
                Console.ReadLine();
            }
            else
            {
                
                Console.WriteLine(sArray[i]);//displays input index

                
                Console.WriteLine(iArray[j]);//displays input index

                Console.WriteLine(StriList[k]);

                Console.ReadLine();

            }
        }
    }
}
