using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionContinued
{
    internal class Bank
    {
        public void withdraw(int amount)
        {
            if (amount > 500)
            {
                throw (new CashWithdrawlException("NOT ALLOWED INSUFFICIENT BALANCE "));
            }
            else
            {
                Console.WriteLine("Money Is Taken");
            }
        }
        public void MakeFD(int amount)
        {
            if (amount >= 50 && amount <= 1000)
            {
                throw new FixedDepositException("NOT ALLOWED ");
            }
            else
            {
                Console.WriteLine("FD IS CREATED SUCCESSFULLY !!!");
            }
        }
    }
}
