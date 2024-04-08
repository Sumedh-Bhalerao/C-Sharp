using multilevel_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Student std = new Student();
        std.m1();
        Employee e = new Employee();
        e.test();
    }
}