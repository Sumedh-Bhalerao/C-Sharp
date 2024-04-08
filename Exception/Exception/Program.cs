internal class Program
{
    public static void m1()
    {
        try 
        {
            Console.WriteLine("Inside A Try.");
            int a = 100, b = 0, c;
            c = a / b;
            Console.WriteLine(c);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Inside A Catch.");
            Console.WriteLine(ex.Message);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        m1();
    }
}