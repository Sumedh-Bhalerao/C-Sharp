using System.ComponentModel.Design;

public delegate void MycalDelegate(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        MycalDelegate Add = delegate (int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine(c);
        };
        Add(10, 20);

        MycalDelegate sub = delegate (int a, int b)
        {
            int c;
            c = a - b;
            Console.WriteLine(c);
        };
        sub(1000, 500);

        MycalDelegate multiply = delegate (int a, int b)
        {
            int c;
            c = a * b;
            Console.WriteLine(c);
        };
        multiply(200, 500);

        MycalDelegate divide = delegate (int a, int b)
        {
            int c;
            c = a / b;
            Console.WriteLine(c);
        };
        divide(200, 10);

        MycalDelegate maxnum = delegate (int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }


        };
        maxnum(10, 20);

    }
}
