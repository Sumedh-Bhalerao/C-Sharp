using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionContinued
{
    internal class FixedDepositException : ApplicationException

    {
        public FixedDepositException(string message) : base(message)
        {

        }
    }
}
