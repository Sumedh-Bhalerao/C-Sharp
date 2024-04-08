
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
