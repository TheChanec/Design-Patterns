using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Proxy.Example1
{
    class Math : IMath
    {
        public int Resta(int x, int y)
        {
            return x-y;
        }

        public int Suma(int x, int y)
        {
            return x + y;
        }
    }
}
