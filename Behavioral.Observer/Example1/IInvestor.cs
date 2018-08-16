using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Observer.Example1
{
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
