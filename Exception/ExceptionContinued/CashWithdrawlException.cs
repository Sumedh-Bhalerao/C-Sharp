using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionContinued
{
    internal class CashWithdrawlException : ApplicationException
    {
        string message;
        public CashWithdrawlException()
        {
            message = "Some msg";
        }
        public CashWithdrawlException(string message) : base(message)
        {
            _ = this.message;
        }
    }
}
