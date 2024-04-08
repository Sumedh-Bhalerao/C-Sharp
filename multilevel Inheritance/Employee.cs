using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_Inheritance
{
    internal class Employee: Student
    {
        protected int eid;
        protected string dept;
        public void test() 
        {
            name = "Emp1";
            Address = "Kothrud";
            email = "test@gmail.com";
            eid= 123;
            dept = "Sales";
            Console.WriteLine(name + "" + email + "" + eid + "" + dept);
        }
    }
}
