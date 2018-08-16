using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsibility.Example1
{
    abstract class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
