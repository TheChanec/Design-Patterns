using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsibility.Example1
{
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            throw new NotImplementedException();
        }
    }
}
