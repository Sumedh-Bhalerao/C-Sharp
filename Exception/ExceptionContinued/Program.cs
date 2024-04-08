using ExceptionContinued;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Bank b = new Bank();
        try
        {
            b.withdraw(3000);
            b.MakeFD(500);
        }
        catch(CashWithdrawlException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        catch (FixedDepositException ex)
        {
            Console.WriteLine(ex.Message);         
        }

    }
}