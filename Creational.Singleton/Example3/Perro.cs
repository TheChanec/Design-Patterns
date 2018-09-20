using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton.Example3
{
    class Perro
    {
        private static Perro perro;

        public Perro GetInstancia()
        {
            if (perro == null)
            {
                return perro = new Perro();
            }
            return perro;
        }
    }
}