using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton.Example3
{
    class Perro
    {
        private static Perro perro;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Perro GetInstancia()
        {
            if (perro == null)
            {
                return perro = new Perro();
            }
            return perro;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}