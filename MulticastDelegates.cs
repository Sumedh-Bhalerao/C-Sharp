using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void mydel();
    internal class DemoMultiCastDelegate
    {
        public static void m1()
        {
            Console.WriteLine("inside a method m1");
        }
        public static void m2()
        {
            Console.WriteLine("inside a method m2");
        }
        public static void m3()
        {
            Console.WriteLine("inside a method m3");
        }
        public static void Main(string[] args)
        {
            //mydel d = new mydel(m1);
            //d += new mydel(m2);
            //d += new mydel(m3);
            //d();


            mydel d = new mydel(m1);
            mydel d1 = new mydel(m2);

            mydel d3 = d + d1;
            d3();
            mydel d4 = d3 - d1;
            d4();


        }
        

    }
}
