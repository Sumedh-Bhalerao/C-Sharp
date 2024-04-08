using System;
using System.Net.Security;
using InheritanceDemo;
namespace ClassLibrary1
{
    public class Class1: Employee1
    {
        public void test()
        {
            eid = 123;
            ename = "Emp1";
            dept = "Marketing";
            Console.WriteLine("Hello World");
        }
    }
}