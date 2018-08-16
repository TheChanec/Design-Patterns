using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Iterator.Example1
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
