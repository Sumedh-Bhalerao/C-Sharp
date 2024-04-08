internal class Program
{
	private static void Main(string[] args)
	{
		int[] arr = { 1, 2, 3, 4, 5 };
		double[] arr1 = { 1.1, 1.2, 1.3, 1.4, 1.5 };
		for (int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
		Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
		foreach (int a in arr)
		{
			Console.WriteLine(a);
		}

		foreach (double d in arr1)
		{
			Console.WriteLine(d);
		}

	}
}
