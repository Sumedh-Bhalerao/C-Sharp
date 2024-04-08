//Student.cs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Stack
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push(100);
            st.Push(4.5);
            st.Push("string");
            foreach (object o in st)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

            Console.WriteLine("After Poping Then Iterate");
            foreach (object o in st)
            {
                Console.WriteLine(o);
            }

            System.Collections.Stack st1 = new System.Collections.Stack();
            st1.Push(500);
            st1.Push(5.5);
            st1.Push("I Am A Stack");

            // Console.WriteLine(st1.Pop());
            // Console.WriteLine(st1.Peek());

            foreach (object o in st1)
            {
                Console.WriteLine(o);
            }
        }
    }
}


//fruit.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingClasses
{
   
   /* internal class Fruit
    {
        //variables
        public int Qty;
        public string Color;
        public double price;

        public void display_calorie()
        {
            Console.WriteLine("Fruits have some calories");
            Console.WriteLine("Apple will have 2 calories");
            Console.WriteLine("Banana will have 4 calories");
        }

        public void print_price()
        {
            Console.WriteLine("Prices of fruits");
            Console.WriteLine("Banana 60/-");
            Console.WriteLine("Apple 20/-");
        }
    }*/
}

//program.cs 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             Fruit apple = new Fruit();
             apple.Qty = 1;
             apple.price = 120;
             apple.Color = "Red";
             Console.WriteLine(apple.Qty);
             Console.WriteLine(apple.price);
             Console.WriteLine(apple.Color);
             apple.print_price();
             apple.display_calorie();*/

             Student student = new Student();
             
            /* student.Accept(10, "Rahul", "CSharp", "5673834828");
             Console.WriteLine(student);*/

            //To Accept From User

            int a;
            string n, c, cnumber;
            Console.WriteLine("Enter Rollno,Name,Course,Cnumber");
            a =Convert.ToInt32(Console.ReadLine());
            n = Console.ReadLine();
            c = Console.ReadLine();
            cnumber = Console.ReadLine();
            student.Accept(a, n, c, cnumber);

        }
    }
}

