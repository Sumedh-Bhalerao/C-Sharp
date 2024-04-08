using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_Inheritance
{
    internal class Student:Person
    {
        protected string course_name;
        public void m1()
        {
            name = "student1";
            Address = "Pune";
            email = "test@123";
            Console.WriteLine(name);
            Console.WriteLine(Address);
            Console.WriteLine(email);

        }
    }
}
