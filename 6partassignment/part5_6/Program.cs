﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newList = new List<string>() { "dog", "cat", "bunny", "fish", "horse", "goat", "horse" };
            Console.WriteLine("Please enter an animal from the list");
            string inputanimal = Console.ReadLine();

            int i = 0;
            foreach (string name in newList)
            {
                if (inputanimal == name)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.ReadLine();


            List<string> anotherlist = new List<string> { "car", "truck", "plane", "boat", "car", "motorcycle", "plane" };
            List<string> checklist = new List<string>();
            foreach(string name in anotherlist)
            {
                if (checklist.Contains(name))
                {
                    Console.WriteLine(name + " has already appeared prior to this");
                }
                else
                {
                    Console.WriteLine(name + " has not appeared on this prior to this");
                    checklist.Add(name);
                }
               
            }
            Console.ReadLine();


        }
    }
}
