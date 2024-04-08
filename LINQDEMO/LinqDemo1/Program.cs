using System.Diagnostics.Tracing;
using System.Transactions;

namespace LinqDemo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Employee> elist = new List<Employee>();

            //object initializer syntax
            elist.Add(new Employee() { eid = 12, name = "emp1", dept = "Sales",    salary = 214789 });
            elist.Add(new Employee() { eid = 23, name = "emp2", dept = "Marketing", salary = 205634 });
            elist.Add(new Employee() { eid = 14, name = "emp3", dept = "Sales",     salary = 347895 });
            elist.Add(new Employee() { eid = 20, name = "emp4", dept = "Accounts",  salary = 347569 });
            elist.Add(new Employee() { eid = 45, name = "emp5", dept = "Marketing", salary = 205634 });

            //fetching select * from table_name
            var fetch = from e in elist select e;
            foreach (var x in fetch)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",x.eid,x.name,x.dept,x.salary);
            }

            //where select * from table_name where condition...

            Console.WriteLine("====================================================================");    
            Console.WriteLine("for condition in linq");

            var w = from e in elist where e.dept == "Sales" select e;
            foreach(var x in w)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", x.eid, x.name, x.dept, x.salary);
            }

            //select name,dept from table where dept=="Sales"

            Console.WriteLine("====================================================================");
            Console.WriteLine("\nDisplaying only selected columns\n");
            Console.WriteLine("1st Example");

            var w1 = from e in elist where e.dept == "Sales" select new { empname = e.name, salary_of_emp = e.salary };
            foreach (var v in w1)
            {
                Console.WriteLine("{0}\t\t{1}", v.empname, v.salary_of_emp);
            }
            Console.WriteLine("______________________________________________________________________");
            Console.Write("\n2nd Example\n");
            
            var w2 = from e in elist where e.salary >= 250000 select new { empname = e.name, empdept = e.dept, empsalary=e.salary };
            foreach (var c in w2)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}",c.empname,c.empdept,c.empsalary);
            }

            Console.WriteLine("====================================================================");
            Console.WriteLine("\nOrder by");
            Console.WriteLine("\n Ascending Order");

            var order = from a in elist orderby a.eid select new { empid=a.eid,empname = a.name, empdept = a.dept, empsalary = a.salary };
            foreach (var a1 in order)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", a1.empid, a1.empname, a1.empdept,a1.empsalary);
            }

            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("Descending Order");

            var orderByDescendingResult = from s in elist orderby s.eid descending select s;
            foreach (var b in orderByDescendingResult)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",b.eid,b.name,b.dept,b.salary);
            }
            Console.WriteLine("====================================================================");


            //Where
           /* var fetch2 = from e in elist where e.name="emp1" && e.dept = "Sales" select e;
            Console.WriteLine("Where Clause");
            foreach (var x in fetch2)
            {
                Console.WriteLine(x);   
            }*/
        }
    }
}