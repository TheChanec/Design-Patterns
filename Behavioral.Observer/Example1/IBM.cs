using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Observer.Example1
{
    class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
