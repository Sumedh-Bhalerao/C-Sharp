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

//Employee.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Employee
    {
        public int eid;
        public string ename, dept, skill;

        public void printdetails()
        {
            eid = 1;
            ename = "emp1";
            dept = "sales";
            skill = "sales";
            Console.WriteLine("Print method using member variables");
            Console.WriteLine("eid");
            Console.WriteLine("ename");
            Console.WriteLine("dept");
            Console.WriteLine("skill");
        }

        public void m1()
        {
            eid = 2;
            ename = "emp2";
            dept = "Purchase";
            skill = "MBA";
            Console.WriteLine("m1 method using member variables");
            Console.WriteLine("eid");
            Console.WriteLine("ename");
            Console.WriteLine("dept");
            Console.WriteLine("skill");
        }
    }
}

