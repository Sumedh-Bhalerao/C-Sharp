internal class Program
{
    static void m1()
    {
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("Inside m1");
            Console.WriteLine(i);
        }
    }

    static void m2()
    {
        for (int i = 4; i <= 6; i++)
        {
            Console.WriteLine("Inside m2");
            Console.WriteLine(i);
        }
    }


    static void PrintTable()
    {
        for (int i = 1; i <= 10; i++)
        {
           
            Console.WriteLine("The Table Is :{0}",2*i);
        }
    }

    private static void Main(string[] args)
    {
       /* Thread t1 = new Thread(new ThreadStart (m1));
        t1.Start();
        Thread t2 = new Thread(new ThreadStart(m2));
        t2.Start();*/

        Program p = new Program();
        ThreadStart ts = new ThreadStart(m1);
        ThreadStart ts1 = new ThreadStart(m2);
        ThreadStart ts2 = new ThreadStart(PrintTable);
        Thread t1 = new Thread(ts);
        t1.Start();
        Thread t2 = new Thread(ts1);
        t2.Start();
        Thread t3 = new Thread(ts2);
        t3.Start();
     }
}
