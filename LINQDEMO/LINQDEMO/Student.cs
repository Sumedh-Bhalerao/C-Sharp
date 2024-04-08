using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDEMO
{
    public class Student
    {
        /*  public int Sid { get; set; }
          public string Name { get; set; }
          public string Course { get; set; }*/

       public int sid;
        public string name, course;

        public Student() { }
        public Student(int sid, string name, string course)
        { 
            this.sid = sid;
            this.name = name;
            this.course = course;
        }

        public override string ToString() 
        {
            return sid+" "+name+" "+course; 
        }

    }
}
