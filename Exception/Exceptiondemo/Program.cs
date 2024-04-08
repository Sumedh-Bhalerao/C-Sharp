using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(arr[10]);
        }
        catch (Exception ex)
        {
           Console.WriteLine(ex.Message);
           //Console.WriteLine(ex.StackTrace);
           //Console.WriteLine(ex.ToString());
           //Console.WriteLine(ex.HelpLink);
           //Console.WriteLine(ex.Source);
            Console.WriteLine("No Element Found");

        }
        finally
        {
            Console.WriteLine("I Am A Finally Block");
                }
    }
}