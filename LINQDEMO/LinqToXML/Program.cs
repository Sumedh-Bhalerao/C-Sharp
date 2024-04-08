
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Xml.Linq;


    internal class Program
    {

        public static void LoadXml()
        {
            string path = @"C:\Users\sumed\source\repos\LINQDEMO\LinqToXML\XMLFile1.xml";
            XDocument document = XDocument.Load(path);
            Console.WriteLine(document);

        var q = from d in document.Descendants("Student") select new {sid = d.Attribute("id").Value,sname = d.Element("name").Value,Mobilenumber = d.Element("mobile").Value,CourseName = d.Element("course").Value};
           Console.WriteLine(q);
        foreach ( var x in q ) 
        {
         Console.WriteLine("Sid: {0}\tName:{1}\tMobileNumber:{2}\tCourseName:{3}",x.sid,x.sname,x.Mobilenumber,x.CourseName);
        }
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LoadXml();
        }
    }
