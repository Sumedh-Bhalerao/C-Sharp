using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace LINQDEMO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

          
            List<Student> stlist = new List<Student>();

            /* Student st1 = new Student();
             st1.Course = "DotNet";
             st1.Name = "Student1";
             st1.Sid = 123;

             Student st2 = new Student();
             st2.Course = "CSharp";
             st2.Name = "Student2";
             st2.Sid = 124;

             stlist.Add(st1);
             stlist.Add(st2);*/

            /* stlist.Add(new Student() { Name = "Student1", Course = "DotNet", Sid = 123});
             stlist.Add(new Student() { Name = "Student2", Course = "CSharp", Sid = 124 });

             var query = from s in stlist select s;

             foreach (var q in query) 

             {
                 Console.WriteLine(q.Sid);  
                 Console.WriteLine(q.Name);
                 Console.WriteLine(q.Course);
             }*/

           stlist.Add(new Student() { sid = 123,name="Student1",course="Dotnet"});
            stlist.Add(new Student() { sid = 124, name = "Student2", course = "Data Science" });
            stlist.Add(new Student() { sid = 125, name = "Student3", course = "Csharp" });
            stlist.Add(new Student() { sid = 126, name = "Student4", course = "Java" });
             stlist.Add(new Student() { sid = 127, name = "Student5", course = "Angular" });

            var query = from s in stlist select s;

            foreach (var q in query)
            {
                Console.WriteLine(q.sid);
                Console.WriteLine(q.name);
                Console.WriteLine(q.course);
            }


        }
    }
}