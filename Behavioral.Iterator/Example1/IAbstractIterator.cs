using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Iterator.Example1
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
