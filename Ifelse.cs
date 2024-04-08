internal class Program
{
	private static void Main(string[] args)
	{
		int opt = 1;
		int a = 100, b = 20, c;

		if (opt == 1)
		{
			c = a + b;
			Console.WriteLine(c);
		}
		if (opt == 2)
		{
			c = a - b;
			Console.WriteLine(c);
		}
		if (opt == 3) 
		{
			c = a * b;
			Console.WriteLine(c);
		}
		if (opt == 4)
		{
			c = a / b;
			Console.WriteLine(c);
		}
		else 
		{
			Console.WriteLine("choose from 1-4 only");
		}

	}
}
