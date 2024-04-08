using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo
{
    internal class Employee1
    {
        string Fname, Lname;
        int salary;
        public Employee1() { 
        
        }
        public Employee1(string Fname,string Lname,int salary) { 
        this.Fname = Fname;
        this.Lname = Lname;
        this.salary = salary;
            Console.WriteLine("Employee Info");
            Console.WriteLine(Fname + " " + Lname + "" + base ,salary, "" + salary);
        }
    }
}
