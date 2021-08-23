using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObject
{
    public class Employee : Person //inherits from person class
    {
        
        public int Id { get; set; }

        public override void SayName()//uses Person.SayName as base
        {
            Console.WriteLine("This is the information requested");
            base.SayName();
        }


    }
}


