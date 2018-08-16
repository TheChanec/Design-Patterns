using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Proxy.Example1
{
    class MathProxy : IMath
    {
        private Math _math = new Math();

        public int Resta(int x, int y)
        {
            return _math.Resta(x, y);
        }

        public int Suma(int x, int y)
        {
            return _math.Suma(x, y);
        }


    }
}
