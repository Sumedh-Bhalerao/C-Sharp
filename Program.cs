internal class Program
{
	private static void Main(string[] args)
	{
		int a, b, c;
		string opt;
		Console.WriteLine("enter a,b");
		a = Convert.ToInt32(Console.ReadLine());
		b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("+ Addition\n - Substraction\n * Multiplication\n / Division");
		Console.WriteLine("Select Your Option");
		opt = Console.ReadLine();

		switch(opt)
		{
			case "+":
				c = a + b;
				Console.WriteLine(c);
				break;
			case "-":
				c = a - b;
				Console.WriteLine(c);
				break;
			case "*":
				c = a * b;
				Console.WriteLine(c);
				break;
			case "/":
				c = a / b;
				Console.WriteLine(c);
				break;
		}
	}
}