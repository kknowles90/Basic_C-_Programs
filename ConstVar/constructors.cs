using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Student
    {
        string _Id = "";
        string _FName = "";
        string _LName = "";

        public Student(string id)
            : this(id, "", "")//chained constructor with 1
        {

        }

        public Student(string id, string fName)
            : this(id, fName, "")//Chained constructor with 2
        {

        }

        public Student(string id, string fName, string lName)
        {
            _Id = id;
            _FName = fName;
            _LName = lName;
        }

    }
}
