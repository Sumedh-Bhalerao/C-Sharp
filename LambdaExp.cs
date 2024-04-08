internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var x = () => Console.WriteLine("I am a Lambda Funct");
        x();

        var square = (int x) => x * x;
        Console.WriteLine(square(100));
    }
}
