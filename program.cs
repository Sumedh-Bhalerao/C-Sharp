using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class program
    {
        static void Main(string[] args) 
        { 
            Employee employee = new Employee();
            employee.skill = "sales";
            employee.dept = "sales";
            employee.ename = "Praful";
            employee.eid = 190;
       
            Employee employee2 = new Employee();
            employee2.skill = "dotnet";
            employee2.dept = "developement";
            employee2.ename = "Lokesh";
            employee2.eid = 191;
            
            employee.printdetails();
            employee.m1();
        }
    }
}
