using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Facade.Example1
{
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
